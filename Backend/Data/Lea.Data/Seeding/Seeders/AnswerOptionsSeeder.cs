namespace Lea.Data.Seeding.Seeders;

public class AnswerOptionsSeeder : BaseSeeder<AnswerOptionRepository>
{
    public AnswerOptionsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new AnswerOptionRepository[]
        {

        };
    }
}
