using LibraryAppBackend.Application.DTOs.Auth;
using LibraryAppBackend.Domain.Common.Identity;

namespace LibraryAppBackend.Application.Services;

public interface ITokenService
{
    public AccessToken CreateAccessToken(User user, List<OperationClaim> operationClaims);
}