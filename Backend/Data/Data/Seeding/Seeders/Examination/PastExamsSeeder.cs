using Data.Entities.Examination;

namespace Data.Seeding.Seeders.Examination;

public class PastExamsSeeder : BaseSeeder<PastExam>
{
    public PastExamsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new PastExam[]
        {

        };
    }
}