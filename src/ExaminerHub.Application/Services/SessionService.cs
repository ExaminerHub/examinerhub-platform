using ExaminerHub.Domain.Entities;

namespace ExaminerHub.Application.Services;

public class SessionService
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