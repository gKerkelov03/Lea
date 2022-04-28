using Lea.Data.Repositories.Channels;

namespace Lea.Data.Seeding.Seeders;

public class TeachersSeeder : BaseSeeder<ChannelMessagesRepository>
{
    public TeachersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new ChannelMessagesRepository[]
        {

        };
    }
}