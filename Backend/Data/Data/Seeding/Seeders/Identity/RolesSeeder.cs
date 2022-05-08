using Data.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using static Common.GlobalConstants;

namespace Data.Seeding.Seeders.Identity;

public class RolesSeeder : BaseSeeder<LeaRole>
{
    private readonly IServiceProvider serviceProvider;

    public RolesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new LeaRole[]
        {
            new LeaRole { Name = directorRoleName },
            new LeaRole { Name = adminRoleName },
            new LeaRole { Name = lectorRoleName },
            new LeaRole { Name = studentRoleName },

            new LeaRole { Name = directorRoleName },
            new LeaRole { Name = adminRoleName },
            new LeaRole { Name = lectorRoleName },
            new LeaRole { Name = studentRoleName }
        };

        this.serviceProvider = serviceProvider;
    }

    public override async Task SeedAsync()
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<LeaRole>>();

        foreach (var role in dataToSeed)
        {
            await roleManager.CreateAsync(role);
        }
    }
}