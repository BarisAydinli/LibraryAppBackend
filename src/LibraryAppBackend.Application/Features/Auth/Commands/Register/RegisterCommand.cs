using LibraryAppBackend.Application.DTOs.Auth;
using LibraryAppBackend.Domain.Common.Identity;
using MediatR;

namespace LibraryAppBackend.Application.Features.Auth.Commands.Register;

public sealed record RegisterCommandRequest
    (string FirstName, string LastName, string Email, string Password) : IRequest<RegisterCommandResponse>;

public sealed record RegisterCommandResponse(AccessToken AccessToken, IEnumerable<OperationClaim> OperationClaims);