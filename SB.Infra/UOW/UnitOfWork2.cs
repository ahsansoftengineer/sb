using SB.Infra.Entity.SBz;
using SB.Infra.Entity.Donor;
using SB.Infra.Entity.Extraz;
using SB.Infra.Entity.Hierarchy;
using SB.Infra.Entity.MadaniBastaEntity;
using SB.Infra.Entity.Regionz;
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
