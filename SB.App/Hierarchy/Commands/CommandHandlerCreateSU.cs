using SB.App.Common.Persistence.Hierarchy;
using SB.App.Simple;
using SB.Domain.HierarchyAggregate;
using SB.Domain.SimpleAggregates;
using ErrorOr;
using MediatR;

namespace SB.App.Hierarchy.Commands
{
  public class CommandHandlerCreateSU : IRequestHandler<SimpleCommandChildCreate<SU>, ErrorOr<SU>>
  {
    private readonly ISURepo Repo;

    public CommandHandlerCreateSU(ISURepo repo)
    {
      Repo = repo;
    }

    public async Task<ErrorOr<SU>> Handle(SimpleCommandChildCreate<SU> request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      var item = SU.Create(
          parentId: SimpleValueObject.Create(request.ParentId),
          title: request.Title,
          description: request.Description);
      Repo.Add(item);
      return item;
    }
  }
}
