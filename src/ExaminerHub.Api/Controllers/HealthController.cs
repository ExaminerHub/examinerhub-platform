using Microsoft.AspNetCore.Mvc;

namespace ExaminerHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            application = "ExaminerHub",
            status = "Running",
            version = "0.0.1"
        });
    }
}