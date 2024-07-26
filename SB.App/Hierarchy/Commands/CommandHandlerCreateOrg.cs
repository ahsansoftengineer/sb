using SB.App.Common.Persistence.Hierarchy;
using SB.App.Simple;
using SB.Domain.HierarchyAggregate;
using ErrorOr;
using MediatR;

namespace SB.App.Hierarchy.Commands
{
  public class CommandHandlerCreateOrg : IRequestHandler<SimpleCommandCreate<Org>, ErrorOr<Org>>
  {
    private readonly IOrgRepo Repo;

    public CommandHandlerCreateOrg(IOrgRepo repo)
    {
      Repo = repo;
    }
    public async Task<ErrorOr<Org>> Handle(SimpleCommandCreate<Org> request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      var item = Org.Create(
          title: request.Title,
          description: request.Description) ;
      Repo.Add(item);
      return item;
    }
  }
}
