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
}