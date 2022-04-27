using Lea.Data.Repositories;

namespace Lea.Data.Seeding.Seeders;

public class TestsSeeder : BaseSeeder<TestRepository>
{
    public TestsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new TestRepository[]
        {

        };
    }
}