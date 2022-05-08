using Data.Entities.Examination;

namespace Data.Seeding.Seeders.Examination;

public class UpcomingExamsSeeder : BaseSeeder<UpcomingExam>
{
    public UpcomingExamsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new UpcomingExam[]
        {

        };
    }
}