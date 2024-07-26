using SB.Domain.Enums;
using SB.Domain.Entity.Extraz;
using SB.Domain.Entity.Hierarchy;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB.Domain.Entity.Donor
{
  [Table("DonorGSB")]
  public class DonorGSB : DonorBasic
  {
    //[ForeignKey(nameof(DonorBasic))]
    //public int? Id { get; set; }
    //public virtual DonorBasic? DonorBasic { get; set; }

    public string? Area { get; set; }
    public string? NearBy { get; set; }

    [ForeignKey(nameof(SU))]
    public int SubUnitId { get; set; }
    public virtual SU? SU { get; set; }

    public YesNo? WillingToJoinDI { get; set; }

    [ForeignKey(nameof(Majlis))]
    public int? DepartmentId { get; set; }
    public virtual Majlis? Department { get; set; }

    [ForeignKey(nameof(Branch))]
    public int? BranchId { get; set; }
    public virtual Branch? Branch { get; set; }

    // FollowUp Conditional With Followup Date
    public YesNo Followup { get; set; }
    public int? FollowupDate { get; set; }
    public SBOption SBOption { get; set; }
    // GSB: "", Self: Amount, Marhoom: {Name, Amount}
    public string? SBOptionData { get; set; }
    //public int? AmountSelf { get; set; }
    //public virtual IList<DonorMarhoom>? DonorMarhooms { get; set; }
  }
}
