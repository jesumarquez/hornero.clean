using ErrorOr;
using Hornero.Clean.Application.Authentication.Commands.Register;
using Hornero.Clean.Application.Authentication.Common;
using Hornero.Clean.Application.Authentication.Queries.Login;
using Hornero.Clean.Contract.Authentication;
using Hornero.Clean.Domain.Entities;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hornero.Clean.Api.Controller
{
    [Route("auth")]
    public class AuthenticationController : ApiController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthenticationController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var command = _mapper.Map<RegisterCommand>(request);

            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);

            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
                errors => Problem(errors)
            );
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var query = _mapper.Map<LoginQuery>(request);

            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(query);

            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
                errors => Problem(errors)
            );
        } 
    }
}