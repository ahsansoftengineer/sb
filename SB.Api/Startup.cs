using SB.API.Config;
using SB.API.DI;
using SB.Infra;
// using Owin;

namespace SB.API
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDICommon();
      services.AddAutoMapper(typeof(MapperInitializerFull));
      services.AddExternalServices();
      services.AddInfrastructure(Configuration);

    }
    public void Configure(IAppBuilder app, IWebHostEnvironment env)
    {
      app.AddExternalConfiguration(env);
      app.UseCors("CorsPolicyAllowAll");
      app.UseHttpsRedirection();
    }
  }
}
