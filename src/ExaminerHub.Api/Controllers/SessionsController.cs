using ExaminerHub.Application.Services;
using Microsoft.AspNetCore.Mvc;
using ExaminerHub.Domain.Entities;

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

    [HttpPost]
    public IActionResult Create(Session session)
    {
        var createdSession = _sessionService.AddSession(session);

        return CreatedAtAction(nameof(Get), new { id = createdSession.Id }, createdSession);
    }
}