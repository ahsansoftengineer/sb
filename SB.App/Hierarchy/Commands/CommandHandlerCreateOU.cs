using SB.App.Common.Persistence.Hierarchy;
using SB.App.Simple;
using SB.Domain.HierarchyAggregate;
using SB.Domain.SimpleAggregates;
using ErrorOr;
using MediatR;

namespace SB.App.Hierarchy.Commands
{
  public class CommandHandlerCreateOU : IRequestHandler<SimpleCommandChildCreate<OU>, ErrorOr<OU>>
  {
    private readonly IOURepo Repo;

    public CommandHandlerCreateOU(IOURepo repo)
    {
      Repo = repo;
    }

    public async Task<ErrorOr<OU>> Handle(SimpleCommandChildCreate<OU> request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      var item = OU.Create(
          parentId: SimpleValueObject.Create(request.ParentId),
          title: request.Title,
          description: request.Description);
      Repo.Add(item);
      return item;
    }
  }
}
