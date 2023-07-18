using System.Collections.Generic;
using Hornero.Clean.Application.Common.Interfaces.Persistence;
using Hornero.Clean.Domain.CastingAggregate;

namespace Hornero.Clean.Infrastrucutre.Persistence
{
    public class CastingRepository : ICastingRepository
    {
        private static List<Casting> _castings = new();
        public void Add(Casting casting)
        {
            _castings.Add(casting);
        }
    }
}