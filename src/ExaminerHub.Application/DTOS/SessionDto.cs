namespace ExaminerHub.Application.DTOs;

public class SessionDto
{
    public Guid Id { get; set; }

    public string CentreName { get; set; } = string.Empty;

    public string CentreAddress { get; set; } = string.Empty;

    public string RoomName { get; set; } = string.Empty;

    public DateTime SessionDate { get; set; }

    public TimeSpan ArrivalTime { get; set; }

    public TimeSpan FirstCandidateTime { get; set; }

    public TimeSpan ExpectedFinishTime { get; set; }

    public string PartnerExaminerName { get; set; } = string.Empty;

    public bool IsRemotePartner { get; set; }

    public string ZoomLink { get; set; } = string.Empty;

    public string Notes { get; set; } = string.Empty;

    public List<ExamAssignmentDto> ExamAssignments { get; set; } = new();
}