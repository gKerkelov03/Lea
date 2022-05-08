using Data.Repositories.Messaging;

namespace Data.Seeding.Seeders.Messaging;

public class ChannelsSeeder : BaseSeeder<ChannelsRepository>
{
    public ChannelsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new ChannelsRepository[]
        {

        };
    }
}