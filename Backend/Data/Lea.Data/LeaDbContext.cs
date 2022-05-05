using Lea.Data.Entities.Core;
using Lea.Data.Entities.Examination;
using Lea.Data.Entities.Identity;
using Lea.Data.Entities.Messaging;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lea.Data;

public class LeaDbContext : IdentityDbContext<LeaUser, LeaRole, Guid>
{
    public LeaDbContext(DbContextOptions<LeaDbContext> options)
        : base(options)
    {
    }

    //Core
    public DbSet<Course> Courses { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Lector> Lectors { get; set; }
    public DbSet<Student> Student { get; set; }
    

    //Secondary
    public DbSet<Folder> Folders { get; set; }
    public DbSet<ExamQuestion> TestQuestions { get; set; }
    public DbSet<ExamQuestionAnswerOption> TestAnswerOptions { get; set; }

    //Channels
    public DbSet<Channel> Channels { get; set; }
    public DbSet<ChannelMessage> ChannelMessages { get; set; }
    public DbSet<Emoji> Emojis { get; set; }
    public DbSet<Poll> Polls { get; set; }
    public DbSet<PollAnswerOption> PollOptions { get; set; }

    //Tests
    public DbSet<UpcomingExam> UpcomingTests { get; set; }
    public DbSet<PastExam> PastTests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaDbContext).Assembly);    
}
