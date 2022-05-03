using Lea.Data.Entities.Examination;

namespace Lea.Data.Seeding.Seeders.Examination;

public class PastExamsSeeder : BaseSeeder<PastExam>
{
    public PastExamsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new PastExam[]
        {

        };
    }
}