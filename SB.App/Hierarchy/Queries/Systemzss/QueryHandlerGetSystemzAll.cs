// using SB.App.Common.Persistence.Hierarchy;
// using SB.Domain.HierarchyAggregate;
// using SB.Domain.Entity.Hierarchy;
// using ErrorOr;
// using MediatR;

// namespace SB.App.Hierarchy.Queries.Systemzss
// {
//   public class QueryHandlerGetSystemzAll : IRequestHandler<SimpleQueryGetAll<Systemz>, ErrorOr<List<Systemz>>>
//   {
//     private readonly ISystemzRepo Repo;

//     public QueryHandlerGetSystemzAll(ISystemzRepo repo)
//     {
//       Repo = repo;
//     }
//     public async Task<ErrorOr<List<Systemz>>> Handle(
//       SimpleQueryGetAll<Systemz> request, 
//       CancellationToken cancellationToken
//     )
//     {
//       if (await Repo.GetAll() is not List<Systemz> data)
//       {
//         return new[] {
//           Domain.Common.Errors.SimpleErrors.DataNotFound("Org"),
//         };
//       }
//       return data;
//     }
//   }
// }
