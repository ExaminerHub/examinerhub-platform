namespace ExaminerHub.Domain.Entities;

public class Session
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public DateTime ScheduledDate { get; set; }

    public string Location { get; set; } = string.Empty;
}