using SB.App.Common.Persistence.Hierarchy;
using SB.App.Simple;
using SB.Domain.HierarchyAggregate;
using SB.Domain.SimpleAggregates;
using ErrorOr;
using MediatR;

namespace SB.App.Hierarchy.Commands
{
  public class CommandHandlerCreateLE : IRequestHandler<SimpleCommandChildCreate<LE>, ErrorOr<LE>>
  {
    private readonly ILERepo Repo;

    public CommandHandlerCreateLE(ILERepo repo)
    {
      Repo = repo;
    }

    public async Task<ErrorOr<LE>> Handle(SimpleCommandChildCreate<LE> request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      var item = LE.Create(
          parentId: SimpleValueObject.Create(request.ParentId),
          title: request.Title,
          description: request.Description);
      Repo.Add(item);
      return item;
    }
  }
}
