﻿// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using SB.Domain.Entity.Hierarchy;

// namespace SB.Infra.Config.Hierarchy
// {
//   internal class SystemzConfig : IEntityTypeConfiguration<Systemz>
//   {
//     public void Configure(EntityTypeBuilder<Systemz> builder)
//     {
//       string name = typeof(Systemz).Name; // type.Name
//       builder.HasData(
//         new Systemz
//         {
//           Id = 1,
//           Title = name + " 1",
//           OrgId = 1,
//           Description = name + " 1 Description",
//         },
//          new Systemz
//          {
//            Id = 2,
//            Title = name + " 2",
//            OrgId = 2,
//            Description = name + " 2 Description",
//          }
//       );
//     }
//   }
// }