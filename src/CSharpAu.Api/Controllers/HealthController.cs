using Microsoft.AspNetCore.Mvc;

namespace CSharpAu.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase {
    [HttpGet]
    public ActionResult<object> Health() => Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
}