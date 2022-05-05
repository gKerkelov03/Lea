using Lea.Data.Entities.Identity;

namespace Lea.Data.Seeding.Seeders.Identity;

public class UsersSeeder : BaseSeeder<LeaUser>
{
    public UsersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new LeaUser[]
        {
            new LeaUser
            {
                
            }
        };
    }
}