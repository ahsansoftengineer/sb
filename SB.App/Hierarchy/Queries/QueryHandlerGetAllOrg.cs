// using SB.App.Common.Persistence.Hierarchy;
// using SB.Domain.HierarchyAggregate;
// using SB.Domain.Entity.Hierarchy;
// using ErrorOr;
// using MediatR;

// namespace SB.App.Hierarchy.Queries
// {
//   public class QueryHandlerGetAllOrg : IRequestHandler<SimpleQueryGetAll<Org>, ErrorOr<List<Org>>>
//   {
//     private readonly IOrgRepo Repo;

//     public QueryHandlerGetAllOrg(IOrgRepo repo)
//     {
//       Repo = repo;
//     }
//     public async Task<ErrorOr<List<Org>>> Handle(
//       SimpleQueryGetAll<Org> request, 
//       CancellationToken cancellationToken
//     )
//     {
//       if (await Repo.GetAll() is not List<Org> data)
//       {
//         return new[] {
//           Domain.Common.Errors.SimpleErrors.DataNotFound("Org"),
//         };
//       }
//       return data;
//     }
//   }
// }
