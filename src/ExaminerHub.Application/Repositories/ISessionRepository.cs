using ExaminerHub.Domain.Entities;

namespace ExaminerHub.Application.Repositories;

public interface ISessionRepository
{
    IEnumerable<Session> GetSessions();
}