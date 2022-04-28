using Lea.Data.Repositories.Tests;

namespace Lea.Data.Seeding.Seeders;

public class TestsSeeder : BaseSeeder<UpcomingTestsRepository>
{
    public TestsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new UpcomingTestsRepository[]
        {

        };
    }
}