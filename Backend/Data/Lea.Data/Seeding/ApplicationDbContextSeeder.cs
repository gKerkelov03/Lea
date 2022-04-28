
using Lea.Data.Seeding.Seeders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Lea.Data.Seeding;

public class ApplicationDbContextSeeder : ISeeder
{
    private readonly LeaDbContext dbContext;
    private readonly IServiceProvider serviceProvider;

    public ApplicationDbContextSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider)
    {
        this.dbContext = dbContext;
        this.serviceProvider = serviceProvider;
    }

    public async Task SeedAsync()
    {
        if (dbContext is null)
        {
            throw new ArgumentNullException(nameof(dbContext));
        }

        if (serviceProvider is null)
        {
            throw new ArgumentNullException(nameof(serviceProvider));
        }

        var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

        var seeders = new ISeeder[]
        {
            new RolesSeeder(dbContext, serviceProvider),
            new UsersSeeder(dbContext, serviceProvider),

            new TestAnswerOptionsSeeder(dbContext, serviceProvider),
            new ClassesSeeder(dbContext, serviceProvider),
            new FoldersSeeder(dbContext, serviceProvider),
            new QuestionsSeeder(dbContext, serviceProvider),
            new SchoolsSeeder(dbContext, serviceProvider),
            new StudentsSeeder(dbContext, serviceProvider),
            new TeachersSeeder(dbContext, serviceProvider),
            new TestsSeeder(dbContext, serviceProvider),
        };

        foreach (var seeder in seeders)
        {
            await seeder.SeedAsync();
            await dbContext.SaveChangesAsync();
            logger.LogInformation($"Seeder {seeder.GetType().Name} has finished.");
        }
    }
}
