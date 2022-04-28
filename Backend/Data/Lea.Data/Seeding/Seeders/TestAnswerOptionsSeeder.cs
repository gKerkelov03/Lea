using Lea.Data.Entities.Secondary;

namespace Lea.Data.Seeding.Seeders;

public class TestAnswerOptionsSeeder : BaseSeeder<TestAnswerOption>
{
    public TestAnswerOptionsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new TestAnswerOption[]
        {

        };
    }
}
