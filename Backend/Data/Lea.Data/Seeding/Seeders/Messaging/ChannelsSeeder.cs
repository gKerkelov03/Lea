using Lea.Data.Repositories.Core;
using Lea.Data.Repositories.Messaging;

namespace Lea.Data.Seeding.Seeders.Messaging;

public class ChannelsSeeder : BaseSeeder<ChannelsRepository>
{
    public ChannelsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new ChannelsRepository[]
        {

        };
    }
}