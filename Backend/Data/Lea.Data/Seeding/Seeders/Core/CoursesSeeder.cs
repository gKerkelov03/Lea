using static Lea.Common.GlobalConstants;
using Lea.Data.Entities.Core;
using Lea.Data.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Lea.Data.Seeding.Seeders.Core;

public class CoursesSeeder : BaseSeeder<Course>
{
    public CoursesSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<LeaRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<LeaUser>>();

        //TODO: Ask a question about this
        //Func<Guid, LeaUser> ab = async id => await userManager.FindByIdAsync(id.ToString());        

        #region Roles
        var allRoles = dbContext.Roles.ToList().Chunk(4);
        var cryptoCourseRoles = allRoles.First();
        var selfImprovementCourseRoles = allRoles.Last();

        var cryptoCourse_directorRole = cryptoCourseRoles[0];
        var cryptoCourse_adminRole = cryptoCourseRoles[1];
        var cryptoCourse_lectorRole = cryptoCourseRoles[2];
        var cryptoCourse_studentRole = cryptoCourseRoles[3];

        var selfImprovementCourse_directorRole = selfImprovementCourseRoles[0];
        var selfImprovementCourse_adminRole = selfImprovementCourseRoles[1];
        var selfImprovementCourse_lectorRole = selfImprovementCourseRoles[2];
        var selfImprovementCourse_studentRole = selfImprovementCourseRoles[3];
        #endregion
        
        #region Groups 
        var cryptoCourse_stableCoinsGroup = new Group
        {
            Name = cryptoCourse_stableCoinsGroupName,
            PictureUrl = "...",
        };
        var cryptoCourse_altcoinsGroup = new Group
        {
            Name = cryptoCourse_altcoinsGroupName,
            PictureUrl = "...",
        };
        var cryptoCourse_foundamentalsGroup = new Group
        {
            Name = cryptoCourse_foundamentalsGroupName,
            PictureUrl = "...",
        };

        var selfImprovementCourse_coldShowersGroup = new Group
        {
            Name = selfImprovementCourse_coldShowersGroupName,
            PictureUrl = "...",
        };
        var selfImprovementCourse_fitnessGroup = new Group
        {
            Name = selfImprovementCourse_fitnessGroupName,
            PictureUrl = "...",
        };
        var selfImprovementCourse_meditationGroup = new Group
        {
            Name = selfImprovementCourse_meditationGroupName,
            PictureUrl = "...",
        };
        #endregion

        LeaUser cryptoCourse_Director = dbContext.Users.Where(user => user.UserName == "cryptoCourseDirector").First();
        LeaUser cryptoCourse_secondAdmin = dbContext.Users.Where(user => user.UserName == "cryptoCourse_secondAdmin").First();
        LeaUser cryptoCourse_firstAdmin = dbContext.Users.Where(user => user.UserName == "cryptoCourse_firstAdmin").First();

        #region Courses
        var cryptoCourse = new Course
        {
            Name = "CryptoCourse_DirectorUserName",
            PictureUrl = "...",
            Director = cryptoCourse_Director,
            Admins = new[] { cryptoCourse_firstAdmin, cryptoCourse_secondAdmin },
            Groups = new[] { cryptoCourse_altcoinsGroup, cryptoCourse_foundamentalsGroup, cryptoCourse_stableCoinsGroup }
        };
        //var selfImprovementCourse = new Course
        //{
        //    Name = "SelfImprovementCourse_DirectorUserName",
        //    PictureUrl = "...",
        //    Director = selfImprovementCourse_Director,
        //    Admins = new[] { selfImprovementCourse_firstAdmin, selfImprovementCourse_secondAdmin },
        //    Groups = new[] { selfImprovementCourse_coldShowersGroup, selfImprovementCourse_fitnessGroup, selfImprovementCourse_meditationGroup }
        //};
        #endregion

        #region Setting Role.Course to concrete Course
        cryptoCourse_directorRole.Course = cryptoCourse;
        cryptoCourse_lectorRole.Course = cryptoCourse;
        cryptoCourse_adminRole.Course = cryptoCourse;
        cryptoCourse_studentRole.Course = cryptoCourse;

        //selfImprovementCourse_directorRole.Course = selfImprovementCourse;
        //selfImprovementCourse_directorRole.Course = selfImprovementCourse;
        //selfImprovementCourse_directorRole.Course = selfImprovementCourse;
        //selfImprovementCourse_directorRole.Course = selfImprovementCourse;
        #endregion

        #region Setting Group.Course to concrete Course
        //cryptoCourse_altcoinsGroup.Course = cryptoCourse;
        //cryptoCourse_foundamentalsGroup.Course = cryptoCourse;
        //cryptoCourse_stableCoinsGroup.Course = cryptoCourse;

        //selfImprovementCourse_meditationGroup.Course = selfImprovementCourse;
        //selfImprovementCourse_fitnessGroup.Course = selfImprovementCourse;
        //selfImprovementCourse_coldShowersGroup.Course = selfImprovementCourse;
        #endregion

        #region Setting Group.Lector to concrete Lector
        //cryptoCourse_altcoinsGroup.Lectors.Add(cryptoCourse_firstLector);
        //cryptoCourse_foundamentalsGroup.Lectors.Add(cryptoCourse_secondLector);

        //selfImprovementCourse_meditationGroup.Lectors.Add(selfImprovementCourse_firstLector);
        //selfImprovementCourse_fitnessGroup.Lectors.Add(selfImprovementCourse_secondLector);
        #endregion

        dataToSeed = new[] { cryptoCourse };
    }
}