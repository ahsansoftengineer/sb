﻿// using SB.Domain.Enums;
// using SB.Domain.Entity.Base;
// using SB.Domain.Entity.Hierarchy;
// using SB.Domain.Entity.Regionz;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace SB.Domain.Entity.Donor
// {
//   [Table("DonorBasic")]
//   public class DonorBasic : BaseEntity
//   {
//     //[ForeignKey(nameof(DonorGSB))]
//     //public int? Id { get; set; }
//     //public virtual DonorGSB? DonorGSB { get; set; }

//     public string? Mobile { get; set; }
//     public string? Email { get; set; }
//     public string? Address { get; set; }
//     //[NotMapped]
//     public Gender? Gender { get; set; }// = Gender.None;

//     [ForeignKey(nameof(DonorType))]
//     public int DonorTypeId { get; set; }
//     public virtual DonorType? DonorType { get; set; }

//     [ForeignKey(nameof(Org))]
//     public int OrgId { get; set; }
//     public virtual Org? Org { get; set; }

//     [ForeignKey(nameof(City))]
//     public int CityId { get; set; }
//     public virtual City? City { get; set; }
//   }
// }
