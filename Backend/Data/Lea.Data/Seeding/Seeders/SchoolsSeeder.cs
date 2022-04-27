using Lea.Data.Repositories;

namespace Lea.Data.Seeding.Seeders;

public class SchoolsSeeder : BaseSeeder<SchoolRepository>
{
    public SchoolsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new SchoolRepository[]
        {

        };
    }
}