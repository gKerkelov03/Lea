using Lea.Data;
using Lea.Data.Entities.Messaging;
using Lea.Data.Seeding;

namespace Lea.Data.Seeding.Seeders.Messaging;

public class PollsSeeder : BaseSeeder<Poll>
{
    public PollsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new Poll[]
        {

        };
    }
}
