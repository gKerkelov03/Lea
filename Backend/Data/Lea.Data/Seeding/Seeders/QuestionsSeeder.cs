using Lea.Data.Repositories.Examination;

namespace Lea.Data.Seeding.Seeders;

public class QuestionsSeeder : BaseSeeder<ExamQuestionsRepository>
{
    public QuestionsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new ExamQuestionsRepository[]
        {

        };
    }
}