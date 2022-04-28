using Lea.Data.Repositories.Channels;

namespace Lea.Data.Seeding.Seeders;

public class SchoolsSeeder : BaseSeeder<EmojisRepository>
{
    public SchoolsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new EmojisRepository[]
        {

        };
    }
}