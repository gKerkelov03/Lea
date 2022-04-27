using Lea.Data.Repositories;

namespace Lea.Data.Seeding.Seeders;

public class TeachersSeeder : BaseSeeder<TeacherRepository>
{
    public TeachersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new TeacherRepository[]
        {

        };
    }
}