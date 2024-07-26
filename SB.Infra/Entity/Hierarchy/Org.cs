using SB.Infra.Entity.Base;

namespace SB.Infra.Entity.Hierarchy
{
  public class Org : BaseEntity
  {
    // This Property Nothing to do with db it just if you want to access the Child will be handle through this property
    public virtual IList<Systemz>? Systemzs { get; set; }
  }
}
