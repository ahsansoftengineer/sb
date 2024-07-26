using SB.Infra.Entity.Attributez;
using SB.Infra.Entity.Base;

namespace SB.Infra.Entity.Regionz
{
  public class Country : BaseEntity
  {
    public virtual IList<State>? States { get; set; }
  }
}
