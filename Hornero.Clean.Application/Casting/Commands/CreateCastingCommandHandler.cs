using System.Threading;
using System.Threading.Tasks;
using ErrorOr;
using Hornero.Clean.Application.Common.Interfaces.Persistence;
using Hornero.Clean.Domain.CastingAggregate;
using MediatR;

namespace Hornero.Clean.Application.Castings.Commands
{
    public class CreateCastingCommandHandler : IRequestHandler<CreateCastingCommand, ErrorOr<Casting>>
    {
        private readonly ICastingRepository _castingRepository;

        public CreateCastingCommandHandler(ICastingRepository castingRepository)
        {
            _castingRepository = castingRepository;
        }

        public async Task<ErrorOr<Casting>> Handle(CreateCastingCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var casting = Casting.Create(
                castingNumber: request.CastingNumber,
                startDateTime: request.StartDateTime
            );

            _castingRepository.Add(casting);

            return casting;
        }

    }
}