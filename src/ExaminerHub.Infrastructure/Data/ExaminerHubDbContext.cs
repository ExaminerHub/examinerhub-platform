using ExaminerHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExaminerHub.Infrastructure.Data;

public class ExaminerHubDbContext : DbContext
{
    public ExaminerHubDbContext(DbContextOptions<ExaminerHubDbContext> options)
        : base(options)
    {
    }

    public DbSet<Session> Sessions => Set<Session>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Session>().HasData(
            new Session
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Title = "B2 First Speaking Session",
                ScheduledDate = new DateTime(2026, 7, 11),
                Location = "Kensite Murcia"
            },
            new Session
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Title = "C1 Advanced Speaking Session",
                ScheduledDate = new DateTime(2026, 7, 14),
                Location = "Kensite Alicante"
            }
        );
    }
}