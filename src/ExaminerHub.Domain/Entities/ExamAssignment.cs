namespace ExaminerHub.Domain.Entities;

public class ExamAssignment
{
    public Guid Id { get; set; }

    public Guid SessionId { get; set; }

    public Session Session { get; set; } = null!;

    public string Level { get; set; } = string.Empty;

    public int PairCount { get; set; }

    public int TrioCount { get; set; }
}