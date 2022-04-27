using Lea.Data.Repositories;

namespace Lea.Data.Seeding.Seeders;

public class QuestionsSeeder : BaseSeeder<QuestionRepository>
{
    public QuestionsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new QuestionRepository[]
        {

        };
    }
}