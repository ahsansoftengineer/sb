using SB.App.Authentication.Common;
using ErrorOr;
using MediatR;

namespace SB.App.Authentication.Commands.Register
{
  public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
  ) : IRequest<ErrorOr<AuthenticationResult>>;
}
