using Microsoft.AspNetCore.Mvc;

namespace Identity.Application.Controllers
{
    [ApiController]
    public class CallbackController : ControllerBase
    {
        [HttpGet("{provider}/callback")]
        public async Task<IActionResult> HandleGetCallback(
            [FromRoute(Name = "provider")] string provider,
                [FromQuery(Name = "code")] string code,
                [FromQuery(Name = "state")] string state,
                [FromQuery(Name = "error")] string? error,
                [FromQuery(Name = "error_description")] string? errorDescription,
                [FromQuery(Name = "issuer")] string? issuer)
        {
            throw new NotImplementedException();
        }
    }
}