// using SB.App.Authentication.Common;
// using SB.App.Common.Interfaces.Authentication;
// using SB.App.Common.Persistence;
// using SB.Domain.Entities;
// using ErrorOr;
// using MediatR;

// namespace SB.App.Authentication.Commands.Register
// {
//   public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
//   {
//     private readonly IJwtTokenGenerator jwtTokenGenerator;
//     private readonly IUserRepository userRepository;

//     public RegisterCommandHandler(
//       IJwtTokenGenerator jwtTokenGenerator,
//       IUserRepository userRepository

//       )
//     {
//       this.jwtTokenGenerator = jwtTokenGenerator;
//       this.userRepository = userRepository;
//     }
//     public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
//     {
//       await Task.CompletedTask;

//       if (userRepository.GetUserByEmail(command.Email) != null)
//       {
//         return Domain.Common.Errors.User.DuplicateEmail;
//       }

//       // Create user (generate unique Id)
//       var user = new User
//       {
//         FirstName = command.FirstName,
//         LastName = command.LastName,
//         Email = command.Email,
//         Password = command.Password
//       };

//       userRepository.Add(user);

//       // Create JWT token
//       var token = jwtTokenGenerator.GenerateToken(user);
//       return new AuthenticationResult(
//         user,
//         token
//       );
//     }
//   }
// }
