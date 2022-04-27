using Lea.Data.Repositories;

namespace Lea.Data.Seeding.Seeders;

public class ClassesSeeder : BaseSeeder<ClassRepository>
{
    public ClassesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new ClassRepository[]
        {

        };
    }
}