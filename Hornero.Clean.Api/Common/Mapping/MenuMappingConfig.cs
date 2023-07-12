using Hornero.Clean.Application.Menus.Commands;
using Hornero.Clean.Contract.Menus;
using Hornero.Clean.Domain.MenuAgregate;
using Mapster;
using MenuSection = Hornero.Clean.Domain.MenuAgregate.Entities.MenuSection;
using MenuItem = Hornero.Clean.Domain.MenuAgregate.Entities.MenuItem;

namespace Hornero.Clean.Api.Common.Mapping
{
    public class MenuMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<(CreateMenuRequest Request, string HostId), CreateMenuCommand>()
                .Map(dest => dest.HostId, src => src.HostId)
                .Map(dest => dest, src => src.Request);

            config.NewConfig<Menu, MenuResponse>()
                .Map(dest => dest.Id, src => src.Id.Value)
                .Map(dest => dest.AverageRating, src => src.AverageRating.Value)
                .Map(dest => dest.HostId, src => src.HostId.Value)
                .Map(dest => dest.DinnerIds, src => src.DinnersIds.Select(dinnerId => dinnerId.Value))
                .Map(dest => dest.MenuReviewIds, src => src.MenuReviewIds.Select(menuId => menuId.Value));

            config.NewConfig<MenuSection, MenuSectionResponse>()
                .Map(dest => dest.Id, src => src.Id.Value);

            config.NewConfig<MenuItem, MenuItemResponse>()
                .Map(dest => dest.Id, src => src.Id.Value);
        }
    }
}