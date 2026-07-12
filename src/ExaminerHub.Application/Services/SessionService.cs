using ExaminerHub.Application.DTOs;
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

    public IEnumerable<SessionDto> GetSessions()
    {
        return _sessionRepository.GetSessions()
            .Select(session => new SessionDto
            {
                Id = session.Id,
                CentreName = session.Centre?.Name ?? string.Empty,
                CentreAddress = session.Centre?.Address ?? string.Empty,
                RoomName = session.Room?.Name ?? string.Empty,
                SessionDate = session.SessionDate,
                ArrivalTime = session.ArrivalTime,
                FirstCandidateTime = session.FirstCandidateTime,
                ExpectedFinishTime = session.ExpectedFinishTime,
                PartnerExaminerName = session.PartnerExaminerName,
                IsRemotePartner = session.IsRemotePartner,
                ZoomLink = session.ZoomLink,
                Notes = session.Notes,

                ExamAssignments = session.ExamAssignments
                    .Select(assignment => new ExamAssignmentDto
                    {
                        Id = assignment.Id,
                        Level = assignment.Level,
                        PairCount = assignment.PairCount,
                        TrioCount = assignment.TrioCount
                    })
                    .ToList()
            })
            .ToList();
    }

    public Session AddSession(Session session)
    {
        return _sessionRepository.AddSession(session);
    }
}