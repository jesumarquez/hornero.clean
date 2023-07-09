using ErrorOr;
using Hornero.Clean.Application.Authentication.Commands.Register;
using Hornero.Clean.Application.Authentication.Common;
using Hornero.Clean.Contract.Authentication;
using Hornero.Clean.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hornero.Clean.Api.Controller
{
    [Route("auth")]
    public class AuthenticationController : ApiController
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var command = new RegisterCommand(
                User: new User
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Password = request.Password
                }
            );

            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);

            return authResult.Match(
                authResult => Ok(MapAuthResult(authResult)),
                errors => Problem(errors)
            );
        }

        private static AuthenticationResponse MapAuthResult(AuthenticationResult authResult)
        {
            return new AuthenticationResponse(
                            Id: authResult.User.Id,
                            FirstName: authResult.User.FirstName,
                            LastName: authResult.User.LastName,
                            Email: authResult.User.Email,
                            Token: authResult.Token
                        );
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var response = new AuthenticationResponse(
                Id: Guid.NewGuid(),
                FirstName: "firstname",
                LastName: "lastName",
                Email: request.Email,
                Token: "token"
            );

            return Ok(response);
        } 
    }
}