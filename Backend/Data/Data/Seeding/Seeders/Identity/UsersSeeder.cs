using Data.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Seeding.Seeders.Identity;

public class UsersSeeder : BaseSeeder<LeaUser>
{
    private readonly IServiceProvider serviceProvider;

    public UsersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new LeaUser[]
        {
            new LeaUser
            {
                Email = "cryptoCourseDirector@abv.bg",
                UserName = "CryptoCourseDirector",
                FirstName = "warren",
                LastName = "tyson",
                ProfilePictureUrl = "..."
            },
            new LeaUser
            {
                Email = "selfImprovementCourseDirector@abv.bg",
                UserName = "SelfImprovementCourseDirector",
                FirstName = "Claudia",
                LastName = "Borisova",
                ProfilePictureUrl = "..."
            },

            new LeaUser
            {
                Email = "cryptoCourse_firstAdmin@abv.bg",
                UserName = "cryptoCourse_firstAdmin",
                FirstName = "georgi",
                LastName = "petrov",
                ProfilePictureUrl = "..."
            },
            new LeaUser
            {
                Email = "cryptoCourse_secondAdmin@abv.bg",
                UserName = "cryptoCourse_secondAdmin",
                FirstName = "andon",
                LastName = "valkov",
                ProfilePictureUrl = "..."
            },

            new LeaUser
            {
                Email = "selfImprovementCourse_firstAdmin@abv.bg",
                UserName = "selfImprovementCourse_firstAdmin",
                FirstName = "miro",
                LastName = "ivanov",
                ProfilePictureUrl = "..."
            },
            new LeaUser
            {
                Email = "selfImprovementCourse_secondAdmin@abv.bg",
                UserName = "selfImprovementCourse_secondAdmin",
                FirstName = "stefan",
                LastName = "kolev",
                ProfilePictureUrl = "..."
            },
        };

        this.serviceProvider = serviceProvider;
    }

    public override async Task SeedAsync()
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<LeaUser>>();

        foreach (var user in dataToSeed)
        {
            await userManager.CreateAsync(user, "1234");
        }
    }
}