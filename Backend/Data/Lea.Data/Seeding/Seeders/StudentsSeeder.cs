using Lea.Data.Repositories.Channels;

namespace Lea.Data.Seeding.Seeders;

public class StudentsSeeder : BaseSeeder<PollsRepository>
{
    public StudentsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new PollsRepository[]
        {

        };
    }
}