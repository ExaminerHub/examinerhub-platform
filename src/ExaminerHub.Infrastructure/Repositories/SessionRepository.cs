using ExaminerHub.Application.Interfaces;
using ExaminerHub.Domain.Entities;
using ExaminerHub.Infrastructure.Data;

namespace ExaminerHub.Infrastructure.Repositories;

public class SessionRepository : ISessionRepository
{
    private readonly ExaminerHubDbContext _context;

    public SessionRepository(ExaminerHubDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Session> GetSessions()
    {
        return _context.Sessions.ToList();
    }

    public Session AddSession(Session session)
    {
        _context.Sessions.Add(session);
        _context.SaveChanges();

        return session;
    }
}