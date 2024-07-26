using Microsoft.EntityFrameworkCore;

namespace SB.Infra.Config
{
  public static class DI
  {
    public static ModelBuilder AddInitialEntityData(this ModelBuilder builder)
    {
      // builder.ApplyConfiguration(new CommonConfigz<Org>());
      // builder.ApplyConfiguration(new SystemzConfig());

      // builder.ApplyConfiguration(new CommonStatusConfigz<DonorType>());
      // builder.ApplyConfiguration(new DonorBasicConfig());
      // builder.ApplyConfiguration(new DonorGSBConfig());



      return builder;
    }
  }
}
