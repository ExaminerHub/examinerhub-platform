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
        var centreId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
        var roomId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
        var sessionId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc");

        modelBuilder.Entity<Centre>().HasData(
            new Centre
            {
                Id = centreId,
                Name = "Kensington Site",
                Address = "Murcia",
                ContactName = "Centre Administrator",
                ContactEmail = "admin@kensite.example",
                ContactPhone = ""
            });

        modelBuilder.Entity<Room>().HasData(
            new Room
            {
                Id = roomId,
                Name = "Room 1"
            });

        modelBuilder.Entity<Session>().HasData(
            new Session
            {
                Id = sessionId,
                CentreId = centreId,
                RoomId = roomId,
                SessionDate = new DateTime(2026, 7, 15),
                ArrivalTime = new TimeSpan(9, 0, 0),
                FirstCandidateTime = new TimeSpan(9, 30, 0),
                ExpectedFinishTime = new TimeSpan(14, 10, 0),
                PartnerExaminerName = "Gemma",
                IsRemotePartner = false,
                ZoomLink = "",
                Notes = "Arrive 30 minutes before the first candidate."
            });

        modelBuilder.Entity<ExamAssignment>().HasData(
            new ExamAssignment
            {
                Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddd01"),
                SessionId = sessionId,
                Level = "FCE FS",
                PairCount = 3,
                TrioCount = 1
            },
            new ExamAssignment
            {
                Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddd02"),
                SessionId = sessionId,
                Level = "PET FS",
                PairCount = 9,
                TrioCount = 0
            },
            new ExamAssignment
            {
                Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddd03"),
                SessionId = sessionId,
                Level = "PET",
                PairCount = 4,
                TrioCount = 0
            });
    }
}