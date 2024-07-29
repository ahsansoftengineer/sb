using SB.App.Common.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SB.App
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApp(this IServiceCollection Services)
    {
      Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

      // // Generic Adding Services
      // Services.AddScoped(
      //   typeof(IPipelineBehavior<,>),
      //   typeof(ValidationBehavior<,>)
      // );

      // Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

      return Services;
    }
  }
}
