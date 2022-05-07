using Lea.Data.Entities.Messaging;

namespace Lea.Data.Seeding.Seeders.Messaging;

public class PollsSeeder : BaseSeeder<Poll>
{
    public PollsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new Poll[]
        {

        };
    }
}
