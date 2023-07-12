using System.Collections.Generic;
using ErrorOr;
using Hornero.Clean.Domain.MenuAgregate;
using MediatR;

namespace Hornero.Clean.Application.Menus.Commands
{
    public record CreateMenuCommand(
        string HostId,
        string Name,
        string Description,
        List<MenuSectionCommand> Sections
    ) : IRequest<ErrorOr<Menu>>;

    public record MenuSectionCommand(
        string Name,
        string Description,
        List<MenuItemCommand> Items
    );

    public record MenuItemCommand(
        string Name,
        string Description
    );
}