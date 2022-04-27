using Lea.Data.Entities;

namespace Lea.Data.Seeding.Seeders;

public class RolesSeeder : BaseSeeder<Role>
{
    public RolesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new Role[]
        {

        };
    }
}