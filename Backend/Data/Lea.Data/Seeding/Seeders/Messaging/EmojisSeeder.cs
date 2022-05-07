using Lea.Data.Entities.Messaging;

namespace Lea.Data.Seeding.Seeders.Messaging;

public class EmojisSeeder : BaseSeeder<Emoji>
{
    public EmojisSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new Emoji[]
        {

        };
    }
}
