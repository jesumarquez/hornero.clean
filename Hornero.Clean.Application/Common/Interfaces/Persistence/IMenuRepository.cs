using Hornero.Clean.Domain.MenuAgregate;

namespace Hornero.Clean.Application.Common.Interfaces.Persistence
{
    public interface IMenuRepository
    {
        void Add(Menu menu);
    }
}