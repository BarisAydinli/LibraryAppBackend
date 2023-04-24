using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LibraryAppBackend.Application.DTOs.Auth;
using LibraryAppBackend.Application.Services;
using LibraryAppBackend.Domain.Common.Identity;
using LibraryAppBackend.Infrastructure.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace LibraryAppBackend.Infrastructure.Services;

public class AuthService : IAuthService
{
    private readonly IOptions<JwtOptions> _jwtOptions;

    public AuthService(IOptions<JwtOptions> jwtOptions)
    {
        _jwtOptions = jwtOptions;
    }

    public AccessToken CreateAccessToken(User user, IEnumerable<OperationClaim> operationClaims)
    {
        var expiration =
            DateTime.Now.AddMinutes(Convert.ToInt32(_jwtOptions.Value.AccessTokenExpiration));

        var securityKey =
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Value.SecurityKey));

        var signingCredentials =
            new SigningCredentials(securityKey, SecurityAlgorithms.Sha512);

        var jwt = new JwtSecurityToken(
            issuer: _jwtOptions.Value.Issuer,
            audience: _jwtOptions.Value.Audience,
            expires: expiration,
            claims: SetClaims(user, operationClaims),
            signingCredentials: signingCredentials,
            notBefore: DateTime.Now
        );

        var token = new JwtSecurityTokenHandler()
            .WriteToken(jwt);

        return new AccessToken()
        {
            Token = token,
            Expiration = expiration,
        };
    }

    private IEnumerable<Claim> SetClaims(User user, IEnumerable<OperationClaim> operationClaims)
    {
        var claims = new List<Claim>
        {
            new (ClaimTypes.NameIdentifier, user.Id.ToString()),
            new (ClaimTypes.Email, user.Email),
            new (ClaimTypes.Name, $"{user.FirstName} {user.LastName}")
        };
        
        claims.AddRange(operationClaims.Select(
            x => new Claim(ClaimTypes.Role, x.Name)));
        
        return claims;
    }
}