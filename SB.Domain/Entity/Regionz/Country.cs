using SB.Domain.Entity.Base;

namespace SB.Domain.Entity.Regionz
{
  public class Country : BaseEntity
  {
    public virtual IList<State>? States { get; set; }
  }
}
