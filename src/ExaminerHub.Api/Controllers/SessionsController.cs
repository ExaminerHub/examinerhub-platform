using ExaminerHub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExaminerHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var sessions = new List<Session>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Title = "B2 First Speaking Session",
                ScheduledDate = DateTime.Today.AddDays(3),
                Location = "Kensite Murcia"
            }
        };

        return Ok(sessions);
    }
}