using LibraryAppBackend.Application.DTOs.Auth;
using LibraryAppBackend.Application.Services;
using LibraryAppBackend.Domain.Common.Identity;

namespace LibraryAppBackend.Infrastructure.Services;

public class TokenService : ITokenService
{
    public AccessToken CreateAccessToken(User user, List<OperationClaim> operationClaims)
    {
        throw new NotImplementedException();
    }
}