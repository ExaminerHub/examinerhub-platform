using ExaminerHub.Application.Interfaces;
using ExaminerHub.Domain.Entities;

namespace ExaminerHub.Infrastructure.Repositories;

public class SessionRepository : ISessionRepository
{
    public IEnumerable<Session> GetSessions()
    {
        return new List<Session>
        {
            new Session
            {
                Id = Guid.NewGuid(),
                Title = "B2 First Speaking Session",
                ScheduledDate = DateTime.Today.AddDays(2),
                Location = "Kensite Murcia"
            }
        };
    }
}