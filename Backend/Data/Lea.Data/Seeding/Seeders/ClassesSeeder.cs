using Lea.Data.Repositories.Core;

namespace Lea.Data.Seeding.Seeders;

public class ClassesSeeder : BaseSeeder<GroupsRepository>
{
    public ClassesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new GroupsRepository[]
        {

        };
    }
}