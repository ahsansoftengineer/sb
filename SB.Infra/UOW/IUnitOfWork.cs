using SB.Infra.Entity.Hierarchy;
using SB.Infra.Repo;

namespace SB.Infra.UOW
{
  public interface IUnitOfWork : IDisposable
  {
    Task Save();
    // HIERARCHY
    // IGenericRepo<Org> Orgs { get; } 
    // IGenericRepo<Systemz> Systemzs { get; }
  }
}
