using Lea.Data.Repositories.Examination;

namespace Lea.Data.Seeding.Seeders;

public class TestsSeeder : BaseSeeder<UpcomingExamsRepository>
{
    public TestsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new UpcomingExamsRepository[]
        {

        };
    }
}