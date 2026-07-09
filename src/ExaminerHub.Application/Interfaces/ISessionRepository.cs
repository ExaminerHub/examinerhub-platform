using ExaminerHub.Domain.Entities;

namespace ExaminerHub.Application.Interfaces;

public interface ISessionRepository
{
    IEnumerable<Session> GetSessions();
}