using Lea.Data;
using Lea.Data.Entities.Messaging;
using Lea.Data.Seeding;

namespace Lea.Data.Seeding.Seeders.Messaging;

public class DirectMessagesSeeder : BaseSeeder<DirectMessage>
{
    public DirectMessagesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new DirectMessage[]
        {

        };
    }
}
