using Lea.Data.Entities.Examination;

namespace Lea.Data.Seeding.Seeders.Examination;

public class UpcomingExamsSeeder : BaseSeeder<UpcomingExam>
{
    public UpcomingExamsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new UpcomingExam[]
        {

        };
    }
}