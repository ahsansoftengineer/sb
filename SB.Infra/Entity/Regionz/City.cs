using SB.Infra.Entity.Attributez;
using SB.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB.Infra.Entity.Regionz
{
  public class City : BaseEntity
  {
    [ForeignKey(nameof(State))]
    public int StateId { get; set; }
    public virtual State? State { get; set; }
  }
}
