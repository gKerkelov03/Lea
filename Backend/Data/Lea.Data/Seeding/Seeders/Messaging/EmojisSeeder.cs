using Lea.Data;
using Lea.Data.Entities.Messaging;
using Lea.Data.Seeding;

namespace Lea.Data.Seeding.Seeders.Messaging;

public class EmojisSeeder : BaseSeeder<Emoji>
{
    public EmojisSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new Emoji[]
        {

        };
    }
}
