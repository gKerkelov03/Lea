using Lea.Data.Repositories.Secondary;

namespace Lea.Data.Seeding.Seeders;

public class QuestionsSeeder : BaseSeeder<TestQuestionsRepository>
{
    public QuestionsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new TestQuestionsRepository[]
        {

        };
    }
}