using Data.Seeding.Seeders.Core;
using Data.Seeding.Seeders.Examination;
using Data.Seeding.Seeders.Identity;
using Data.Seeding.Seeders.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Data.Seeding.Seeders;

public class LeaDbContextSeeder : ISeeder
{
    private readonly LeaDbContext dbContext;
    private readonly IServiceProvider serviceProvider;

    public LeaDbContextSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider)
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

        var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(LeaDbContextSeeder));

        var seeders = new ISeeder[]
        {
            new RolesSeeder(dbContext, serviceProvider),
            new UsersSeeder(dbContext, serviceProvider),


            new CoursesSeeder(dbContext, serviceProvider),

            new FoldersSeeder(dbContext, serviceProvider),
            new UpcomingExamsSeeder(dbContext, serviceProvider),
            new PastExamsSeeder(dbContext, serviceProvider),

            new ChannelsSeeder(dbContext, serviceProvider),
            new DirectMessagesSeeder(dbContext, serviceProvider),
            new EmojisSeeder(dbContext, serviceProvider),
            new PollsSeeder(dbContext, serviceProvider),
        };

        foreach (var seeder in seeders)
        {
            await seeder.SeedAsync();
            await dbContext.SaveChangesAsync();
            logger.LogInformation($"Seeder {seeder.GetType().Name} has finished.");
        }
    }
}
