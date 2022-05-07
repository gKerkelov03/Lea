using static Lea.Common.GlobalConstants;
using Lea.Data.Entities.Core;

namespace Lea.Data.Seeding.Seeders.Core;

public class GroupsSeeder : BaseSeeder<Group>
{
    public GroupsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {        
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

       

        //dataToSeed = new[] { cryptoCourse, selfImprovementCourse };        
    }
}