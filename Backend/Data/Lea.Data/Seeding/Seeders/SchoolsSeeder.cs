using Lea.Data.Repositories.Messaging;

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