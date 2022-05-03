using Lea.Data.Entities.Core;
using Lea.Data.Repositories.Core;

namespace Lea.Data.Seeding.Seeders.Core;

public class CoursesSeeder : BaseSeeder<Course>
{
    public CoursesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new Course[]
        {

        };
    }
}