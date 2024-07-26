using SB.Domain.Entity.Base;
using SB.Domain.Entity.Attributez;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB.Domain.Entity.Hierarchy
{
  public class Systemz : BaseEntity
  {
    [ForeignKey(nameof(Org))]
    public int OrgId { get; set; } // We Marked it as Nullable because of Dynamic Filtering
    [Relate] // For Eager Loading
    public virtual Org? Org { get; set; }

  }
}
