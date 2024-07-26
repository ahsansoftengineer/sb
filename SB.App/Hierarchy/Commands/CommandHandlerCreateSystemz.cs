using SB.App.Common.Persistence.Hierarchy;
using SB.App.Simple;
using SB.Domain.HierarchyAggregate;
using SB.Domain.SimpleAggregates;
using ErrorOr;
using MediatR;

namespace SB.App.Hierarchy.Commands
{
  public class CommandHandlerCreateSystemz : IRequestHandler<SimpleCommandChildCreate<Systemz>, ErrorOr<Systemz>>
  {
    private readonly ISystemzRepo Repo;

    public CommandHandlerCreateSystemz(ISystemzRepo repo)
    {
      Repo = repo;
    }

    public async Task<ErrorOr<Systemz>> Handle(SimpleCommandChildCreate<Systemz> request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      var item = Systemz.Create(
          parentId: SimpleValueObject.Create(request.ParentId),
          title: request.Title,
          description: request.Description);
      Repo.Add(item);
      return item;
    }
  }
}
