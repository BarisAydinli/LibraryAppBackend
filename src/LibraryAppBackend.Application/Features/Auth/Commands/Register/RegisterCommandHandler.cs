using LibraryAppBackend.Application.Services;
using LibraryAppBackend.Application.Services.Data;
using LibraryAppBackend.Domain.Common.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppBackend.Application.Features.Auth.Commands.Register;

internal class RegisterCommandHandler : IRequestHandler<RegisterCommandRequest, RegisterCommandResponse>
{
    private readonly IHashingService _hashingService;
    private readonly IApplicationDbContext _dbContext;
    private readonly IAuthService _authService;

    public RegisterCommandHandler(IHashingService hashingService, IApplicationDbContext dbContext,
        IAuthService authService)
    {
        _hashingService = hashingService;
        _dbContext = dbContext;
        _authService = authService;
    }

    public async Task<RegisterCommandResponse> Handle(RegisterCommandRequest request,
        CancellationToken cancellationToken)
    {
        var (passwordHash, passwordSalt) = _hashingService.CreatePasswordHash(request.Password);

        var user = new User()
        {
            Email = request.Email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            FirstName = request.FirstName,
            LastName = request.LastName,
        };

        await _dbContext.Users.AddAsync(user, cancellationToken);

        var operationClaims = _dbContext.Users
            .Include(e => e.OperationClaims)
            .SelectMany(e => e.OperationClaims).ToList();

        var accessToken = _authService.CreateAccessToken(user, operationClaims);

        return new RegisterCommandResponse(
            AccessToken: accessToken,
            OperationClaims: operationClaims
        );
    }
}