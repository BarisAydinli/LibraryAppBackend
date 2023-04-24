using LibraryAppBackend.Application.DTOs.Auth;
using LibraryAppBackend.Domain.Common.Identity;

namespace LibraryAppBackend.Application.Services;

public interface IAuthService
{
    public AccessToken CreateAccessToken(User user, IEnumerable<OperationClaim> operationClaims);
}