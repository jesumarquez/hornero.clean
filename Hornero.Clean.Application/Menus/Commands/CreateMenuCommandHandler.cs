using System.Threading;
using System.Threading.Tasks;
using ErrorOr;
using Hornero.Clean.Application.Common.Interfaces.Persistence;
using Hornero.Clean.Domain.HostAgregate.ValueObjects;
using Hornero.Clean.Domain.MenuAgregate;
using Hornero.Clean.Domain.MenuAgregate.Entities;
using MediatR;

namespace Hornero.Clean.Application.Menus.Commands
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
            
            var menu = Menu.Create(
                hostId: HostId.CreateUnique(),
                name: request.Name,
                description: request.Description,
                sections: request.Sections.ConvertAll(section => MenuSection.Create(
                    name: section.Name,
                    description: section.Description,
                    items: section.Items.ConvertAll(item => MenuItem.Create(
                        name: item.Name,
                        description: item.Description)))));

            _menuRepository.Add(menu);

            return menu;
        }
    }
}