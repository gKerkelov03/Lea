using Data.Entities.Messaging;

namespace Data.Seeding.Seeders.Messaging;

public class DirectMessagesSeeder : BaseSeeder<DirectMessage>
{
    public DirectMessagesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new DirectMessage[]
        {

        };
    }
}
