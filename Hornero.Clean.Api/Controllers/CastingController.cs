using ErrorOr;
using Hornero.Clean.Application.Castings.Commands;
using Hornero.Clean.Contract.Castings;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hornero.Clean.Api.Controller
{
    [Route("[controller]")]
    public class CastingController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CastingController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCasting(CreateCastingRequest request)
        {
            var createCastingCommand = _mapper.Map<CreateCastingCommand>(request);

            var result = await _mediator.Send(createCastingCommand);

            return result.Match(
                casting => Ok(_mapper.Map<CastingResponse>(casting)),
                errors => Problem(errors)
            );
        }
    }
}