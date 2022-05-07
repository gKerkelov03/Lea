using Lea.Data.Entities.Messaging;

namespace Lea.Data.Seeding.Seeders.Messaging;

public class DirectMessagesSeeder : BaseSeeder<DirectMessage>
{
    public DirectMessagesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new DirectMessage[]
        {

        };
    }
}
