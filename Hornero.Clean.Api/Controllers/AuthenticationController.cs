using Hornero.Clean.Contract.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Hornero.Clean.Api.Controller
{
    [Route("auth")]
    public class AuthenticationController : ApiController
    {
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var response = new AuthenticationResponse(
                Id: Guid.NewGuid(),
                FirstName: request.FirstName,
                LastName: request.LastName,
                Email: request.Email,
                Token: "token"
            );

            return Ok(response);
        } 
    }
}