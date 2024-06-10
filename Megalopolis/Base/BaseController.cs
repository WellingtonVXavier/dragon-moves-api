using Microsoft.AspNetCore.Mvc;

namespace Megalopolis.Base;

[ApiController]
[Route("[controller]")]
public class BaseController : ControllerBase
{
    [HttpGet("ping")]
    [ApiExplorerSettings(IgnoreApi = true)]
    //[AllowAnonymous]
    public IActionResult Ping()
    {
        return Ok($"Pong from {base.ControllerContext.ActionDescriptor.ControllerName}");
    }
}
