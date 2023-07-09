using Microsoft.AspNetCore.Mvc;

namespace Hornero.Clean.Api.Controller
{
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}