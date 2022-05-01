using Lea.Data.Entities.Examination;

namespace Lea.Data.Seeding.Seeders;

public class TestAnswerOptionsSeeder : BaseSeeder<ExamQuestionAnswerOption>
{
    public TestAnswerOptionsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new ExamQuestionAnswerOption[]
        {

        };
    }
}
