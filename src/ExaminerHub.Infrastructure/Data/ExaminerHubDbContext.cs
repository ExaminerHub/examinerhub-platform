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
    public DbSet<Centre> Centres => Set<Centre>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Examiner> Examiners => Set<Examiner>();
    public DbSet<ExamAssignment> ExamAssignments => Set<ExamAssignment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}