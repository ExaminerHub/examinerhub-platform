namespace ExaminerHub.Application.DTOs;

public class ExamAssignmentDto
{
    public Guid Id { get; set; }

    public string Level { get; set; } = string.Empty;

    public int PairCount { get; set; }

    public int TrioCount { get; set; }
}