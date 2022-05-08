using Data.Entities.Core;

namespace Data.Seeding.Seeders.Core;

public class StudentsSeeder : BaseSeeder<Student>
{
    public StudentsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        #region Students
        var cryptoCourse_firstStudent = new Student
        {

        };
        var cryptoCourse_secondStudent = new Student
        {

        };
        var cryptoCourse_thirdStudent = new Student
        {

        };
        var cryptoCourse_fourthStudent = new Student
        {

        };

        var selfImprovementCourse_firstStudent = new Student
        {

        };
        var selfImprovementCourse_secondStudent = new Student
        {

        };
        var selfImprovementCourse_thirdStudent = new Student
        {

        };
        var selfImprovementCourse_fourthStudent = new Student
        {

        };
        #endregion



        //dataToSeed = new[] { cryptoCourse, selfImprovementCourse };        
    }
}