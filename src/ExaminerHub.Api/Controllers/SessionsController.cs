using ExaminerHub.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExaminerHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionsController : ControllerBase
{
    private readonly SessionService _sessionService;

    public SessionsController(SessionService sessionService)
    {
        _sessionService = sessionService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_sessionService.GetSessions());
    }
}