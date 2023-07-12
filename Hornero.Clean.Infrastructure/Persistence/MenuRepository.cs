using System.Collections.Generic;
using Hornero.Clean.Application.Common.Interfaces.Persistence;
using Hornero.Clean.Domain.MenuAgregate;

namespace Hornero.Clean.Infrastrucutre.Persistence
{
    public class MenuRepository : IMenuRepository
    {
        private static List<Menu> _menus = new();
        public void Add(Menu menu)
        {
            _menus.Add(menu);
        }
    }
}