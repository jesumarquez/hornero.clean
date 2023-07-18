using Hornero.Clean.Application.Castings.Commands;
using Hornero.Clean.Contract.Castings;
using Hornero.Clean.Domain.CastingAggregate;
using Mapster;

namespace Hornero.Clean.Api.Common.Mapping
{
    public class CastingMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateCastingRequest, CreateCastingCommand>()
                .Map(dest => dest, src => src);

            config.NewConfig<Casting, CastingResponse>()
                .Map(dest => dest.Id, src => src.Id.Value);
        }
    }
}