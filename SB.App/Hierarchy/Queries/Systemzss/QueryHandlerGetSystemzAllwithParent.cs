using SB.App.Common.Persistence.Hierarchy;
using SB.Domain.HierarchyAggregate;
using ErrorOr;
using MediatR;

namespace SB.App.Hierarchy.Queries.Systemzss
{
  public class QueryHandlerGetSystemzAllwithParent : IRequestHandler<SimpleQueryGetAllwithParent<Systemz>, ErrorOr<List<Systemz>>>
  {
    private readonly ISystemzRepo Repo;

    public QueryHandlerGetSystemzAllwithParent(ISystemzRepo repo)
    {
      Repo = repo;
    }
    public async Task<ErrorOr<List<Systemz>>> Handle(
      SimpleQueryGetAllwithParent<Systemz> request, 
      CancellationToken cancellationToken
    )
    {
      if (await Repo.GetAllwithParent() is not List<Systemz> data)
      {
        return new[] {
          Domain.Common.Errors.SimpleErrors.DataNotFound("Systemz"),
        };
      }
      return data;
    }
  }
}
