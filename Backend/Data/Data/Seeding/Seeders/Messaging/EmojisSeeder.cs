using Data.Entities.Messaging;

namespace Data.Seeding.Seeders.Messaging;

public class EmojisSeeder : BaseSeeder<Emoji>
{
    public EmojisSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new Emoji[]
        {

        };
    }
}
