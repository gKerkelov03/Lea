using Lea.Data.Entities;

namespace Lea.Data.Seeding.Seeders;

public class UsersSeeder : BaseSeeder<LeaUser>
{
    public UsersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new LeaUser[]
        {

        };
    }
}