using SB.App.Common.Persistence.Hierarchy;
using SB.Domain.HierarchyAggregate;
using ErrorOr;
using MediatR;

namespace SB.App.Hierarchy.Queries
{
  public class QueryHandlerGetAllwithChildsOrg : IRequestHandler<SimpleQueryGetAllwithChild<Org>, ErrorOr<List<Org>>>
  {
    private readonly IOrgRepo Repo;

    public QueryHandlerGetAllwithChildsOrg(IOrgRepo repo)
    {
      Repo = repo;
    }
    public async Task<ErrorOr<List<Org>>> Handle(
      SimpleQueryGetAllwithChild<Org> request, 
      CancellationToken cancellationToken
    )
    {
      if (await Repo.GetAllwithChilds() is not List<Org> data)
      {
        return new[] {
          Domain.Common.Errors.SimpleErrors.DataNotFound("Org"),
        };
      }
      return data;
    }
  }
}
