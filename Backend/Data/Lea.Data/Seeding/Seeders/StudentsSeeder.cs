using Lea.Data.Repositories;

namespace Lea.Data.Seeding.Seeders;

public class StudentsSeeder : BaseSeeder<StudentRepository>
{
    public StudentsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new StudentRepository[]
        {

        };
    }
}