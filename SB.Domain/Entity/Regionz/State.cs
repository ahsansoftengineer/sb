using SB.Domain.Entity.Attributez;
using SB.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB.Domain.Entity.Regionz
{
  public class State : BaseEntity
  {
    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; } 
    public virtual Country? Country { get; set; }
    public virtual IList<City>? Citys { get; set; }
  }
}
