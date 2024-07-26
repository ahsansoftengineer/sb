using SB.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB.Domain.Entity.Regionz
{
  public class City : BaseEntity
  {
    [ForeignKey(nameof(State))]
    public int StateId { get; set; }
    public virtual State? State { get; set; }
  }
}
