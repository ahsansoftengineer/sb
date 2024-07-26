using SB.App.Authentication.Common;
using ErrorOr;
using MediatR;

namespace SB.App.Authentication.Query.Login
{
  public record LoginQuery(
      string Email,
      string Password
    ) : IRequest<ErrorOr<AuthenticationResult>>;
}
