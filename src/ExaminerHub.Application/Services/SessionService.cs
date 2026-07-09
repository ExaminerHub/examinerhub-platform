using ExaminerHub.Application.Interfaces;
using ExaminerHub.Domain.Entities;

namespace ExaminerHub.Application.Services;

public class SessionService
{
    private readonly ISessionRepository _sessionRepository;

    public SessionService(ISessionRepository sessionRepository)
    {
        _sessionRepository = sessionRepository;
    }

    public IEnumerable<Session> GetSessions()
    {
        return _sessionRepository.GetSessions();
    }
}