using Lea.Data.Entities.Identity;

namespace Lea.Data.Seeding.Seeders;

public class RolesSeeder : BaseSeeder<LeaRole>
{
    public RolesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new LeaRole[]
        {

        };
    }
}