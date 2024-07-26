using SB.Infra.Entity.Attributez;
using SB.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB.Infra.Entity.Hierarchy
{
  public class Systemz : BaseEntity
  {
    [ForeignKey(nameof(Org))]
    public int OrgId { get; set; } // We Marked it as Nullable because of Dynamic Filtering
    [Relate] // For Eager Loading
    public virtual Org? Org { get; set; }

  }
}
