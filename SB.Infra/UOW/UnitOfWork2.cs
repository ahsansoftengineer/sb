using SB.Domain.Entity.Hierarchy;
using SB.Domain.Entity.Regionz;
using SB.Infra.UOW;

namespace SB.Infra.Repo
{
    public partial class UnitOfWork : IUnitOfWork
  {

    // ??= C# 9 Short-hand Syntax
    // public IGenericRepo<Org> Orgs => _orgs ??= new GenericRepo<Org>(_context);
    // public IGenericRepo<Systemz> Systemzs => _systemz ??= Got<Systemz>();
  }
}
