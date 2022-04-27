using Lea.Data.Entities;

namespace Lea.Data.Seeding.Seeders;

public class UsersSeeder : BaseSeeder<User>
{
    public UsersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new User[]
        {

        };
    }
}