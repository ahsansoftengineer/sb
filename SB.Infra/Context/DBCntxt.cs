using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
// using SB.Domain.Enums;
// using SB.Infra.Config;
// // using SB.Domain.Entity;
// using SB.Domain.Entity.Hierarchy;

namespace SB.Infra.Context
{
  public class DBCntxt : IdentityDbContext<ApiUser>
  {
    public DBCntxt(DbContextOptions options) : base(options) { }
    // public DbSet<Org> Orgs { get; set; }
    // public DbSet<Systemz> Systemzs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.AddInitialEntityData();
    }
    // All below code Commented for future reference
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //
    //{
    //  optionsBuilder.LogTo(Console.WriteLine);
    //}
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  base.OnConfiguring(optionsBuilder);
    //}
    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //  builder.ApplyConfigurationsFromAssembly(
    //    typeof(SBDbContext).Assembly
    //  );
    //  base.OnModelCreating(builder);
    //}    
  }
}
