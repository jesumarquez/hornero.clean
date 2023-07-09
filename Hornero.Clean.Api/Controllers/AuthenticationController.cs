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
            return Ok(request);
        } 
    }
}