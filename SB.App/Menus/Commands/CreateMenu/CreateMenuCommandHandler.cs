using SB.App.Common.Persistence;
//using SB.Domain.Host.ValueObjects;
using SB.Domain.Menu;
using SB.Domain.Menu.Entities;
using ErrorOr;
using MediatR;

namespace SB.App.Menus.Commands.CreateMenu
{
  public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
  {
    private readonly IMenuRepository _menuRepository;

    public CreateMenuCommandHandler(IMenuRepository menuRepository)
    {
      _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      // 1. Create Menu
      var menu = Menu.Create(
          //hostId: HostId.Create(request.HostId),
          name: request.Name,
          description: request.Description,
          sections: request.Sections.ConvertAll(sections => MenuSection.Create(
              name: sections.Name,
              description: sections.Description,
              items: sections.Items.ConvertAll(items => MenuItem.Create(
                  name: items.Name,
                  description: items.Description)))));
      // 2. Persist Menu
      _menuRepository.Add(menu);
      // 3. Return Menu
      return menu;
    }
  }
}
