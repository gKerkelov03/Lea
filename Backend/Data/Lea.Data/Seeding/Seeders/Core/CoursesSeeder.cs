using static Lea.Common.GlobalConstants;
using Lea.Data.Entities.Core;
using Lea.Data.Entities.Identity;
using Lea.Data.Repositories.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Lea.Data.Seeding.Seeders.Core;

public class CoursesSeeder : BaseSeeder<Course>
{
    public CoursesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<LeaRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<LeaUser>>();

        var cryptoCourse = dbContext.Courses.Where(course => course.Director.UserName == CryptoCourse_DirectorUserName).First();
        var selfImprovementCourse = dbContext.Courses.Where(course => course.Director.UserName == SelfImprovementCourse_DirectorUserName).First();

        var cryptoCourseDirector = dbContext.Users.Where(user => user.UserName == SelfImprovementCourse_DirectorUserName).First();
        var selfImprovementCourseDirector = dbContext.Users.Where(user => user.UserName == SelfImprovementCourse_DirectorUserName).First();

        var rolesForTheCryptoCourse = roleManager.Roles.Where(role => role.Course == cryptoCourse);
        var rolesForTheSelfImprovementCourse = roleManager.Roles.Where(role => role.Course == cryptoCourse);

        var cryptoCourseAdminRoles = rolesForTheCryptoCourse.Where(role => role.Name == Roles_AdminRoleName).ToList(); 
        var selfImprovementCourseAdminRoles = rolesForTheSelfImprovementCourse.Where(role => role.Name == Roles_AdminRoleName).ToList();

        var cryptoCourseAdminsIds = dbContext.UserRoles.Where(userRole => cryptoCourseAdminRoles.Any(role => role.Id == userRole.RoleId)).Select(userRole => userRole.UserId).ToList();
        var selfImprovementCourseAdminsIds = dbContext.UserRoles.Where(userRole => selfImprovementCourseAdminRoles.Any(role => role.Id == userRole.RoleId)).Select(userRole => userRole.UserId).ToList();

        var cryptoCourseAdmins = cryptoCourseAdminsIds.Select(id => userManager.FindByIdAsync(id.ToString()).GetAwaiter().GetResult()).ToList();
        var selfImprovementCourseAdmins = selfImprovementCourseAdminsIds.Select(id => userManager.FindByIdAsync(id.ToString()).GetAwaiter().GetResult()).ToList();

        var cryptoCourseGroups = dbContext.Groups.Where(group => group.Course == cryptoCourse).ToList();
        var selfImprovementCourseGroups = dbContext.Groups.Where(group => group.Course == selfImprovementCourse).ToList();

        //TODO: Ask a question about this
        //Func<Guid, LeaUser> ab = async id => await userManager.FindByIdAsync(id.ToString());        

        dataToSeed = new Course[]
        {
            new Course
            {
                Title = CryptoCourse_DirectorUserName,
                PictureUrl = "...",
                Director = cryptoCourseDirector,
                Admins = cryptoCourseAdmins,
                Students = new List<Student>(),
                Groups = cryptoCourseGroups,
                Lectors = new List<Lector>(),
            },
            new Course
            {
                Title = SelfImprovementCourse_DirectorUserName,
                PictureUrl = "...",
                Director = selfImprovementCourseDirector,
                Admins = selfImprovementCourseAdmins,
                Students = new List<Student>(),
                Groups = selfImprovementCourseGroups,
                Lectors = new List<Lector>(),
            },            
        };
    }
}