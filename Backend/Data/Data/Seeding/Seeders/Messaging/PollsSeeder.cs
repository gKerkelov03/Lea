using Data.Entities.Messaging;

namespace Data.Seeding.Seeders.Messaging;

public class PollsSeeder : BaseSeeder<Poll>
{
    public PollsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new Poll[]
        {

        };
    }
}
