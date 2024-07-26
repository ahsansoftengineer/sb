// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using Microsoft.EntityFrameworkCore;
// using SB.Domain.Entity.Donor;
// using SB.Domain.Enums;
// using Newtonsoft.Json;
// using SB.Domain.DTOs.Donor;

// namespace SB.Infra.Config.Donorz
// {
//   internal class DonorGSBConfig : IEntityTypeConfiguration<DonorGSB>
//   {
//     public void Configure(EntityTypeBuilder<DonorGSB> builder)
//     {
//       string name = typeof(DonorGSB).Name; // type.Name
//       builder.HasData(
//         new DonorGSB()
//         {
//           Id = 4,
//           Title = name + " 4",
//           Description = name + " 4 Description",
//           Mobile = "03444444444",
//           DonorTypeId = 1,
//           OrgId = 1,
//           CityId = 1,
//           Email = name + "44@gmail.com",
//           Gender = Gender.Male,
//           Address = name + "44 Address",

//           Area = "44 Area",
//           NearBy = "44 Near By",
//           SubUnitId = 1,
//           WillingToJoinDI = YesNo.No,
//           Followup = YesNo.No,
//           SBOption = SBOption.OptionGSB
//         },
//         new DonorGSB()
//         {
//           Id = 5,
//           Title = name + " 5",
//           Description = name + " 5 Description",
//           Mobile = "03555555555",
//           DonorTypeId = 2,
//           OrgId = 2,
//           CityId = 2,
//           Email = name + "55@gmail.com",
//           Gender = Gender.None,
//           Address = name + "55 Address",

//           Area = "55 Area",
//           NearBy = "55 Near By",
//           SubUnitId = 2,
//           WillingToJoinDI = YesNo.Yes,
//           DepartmentId = 2,
//           BranchId = 2,
//           Followup = YesNo.Yes,
//           FollowupDate = 5, // Number between 1-30
//           SBOption = SBOption.OptionSelf,
//           SBOptionData = "1000",
//         },
//         new DonorGSB()
//         {
//           Id = 6,
//           Title = name + " 6",
//           Description = name + " 6 Description",
//           Mobile = "03666666666",
//           DonorTypeId = 1,
//           OrgId = 2,
//           CityId = 2,
//           Email = name + "33@gmail.com",
//           Gender = Gender.Female,
//           Address = name + "33 Address",

//           Area = "66 Area",
//           NearBy = "66 Near By",
//           SubUnitId = 1,
//           WillingToJoinDI = YesNo.Yes,
//           DepartmentId = 2,
//           BranchId = 2,
//           Followup = YesNo.Yes,
//           FollowupDate = 10, // Number between 1-30
//           SBOption = SBOption.OptionMarhoom,
//           SBOptionData = JsonConvert.SerializeObject(
//             new List<DonorGSBOptionMarhoom>() {
//               new DonorGSBOptionMarhoom()
//               {
//                 name = "Nana",
//                 amount = 1000
//               },
//               new DonorGSBOptionMarhoom()
//               {
//                 name = "Dadi",
//                 amount = 500
//               }
//             }.ToArray()
//           )
//         }
//       );
//     }
//   }
// }
