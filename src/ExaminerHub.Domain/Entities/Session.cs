namespace ExaminerHub.Domain.Entities;

public class Session
{
    public Guid Id { get; set; }

    public Guid CentreId { get; set; }
    public Centre Centre { get; set; } = null!;

    public Guid RoomId { get; set; }
    public Room Room { get; set; } = null!;

    public DateTime SessionDate { get; set; }

    public TimeSpan ArrivalTime { get; set; }

    public TimeSpan FirstCandidateTime { get; set; }

    public TimeSpan ExpectedFinishTime { get; set; }

    public string PartnerExaminerName { get; set; } = string.Empty;

    public bool IsRemotePartner { get; set; }

    public string ZoomLink { get; set; } = string.Empty;

    public string Notes { get; set; } = string.Empty;

    public List<ExamAssignment> ExamAssignments { get; set; } = new();
}