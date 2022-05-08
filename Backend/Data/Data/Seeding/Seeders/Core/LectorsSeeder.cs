using Data.Entities.Core;

namespace Data.Seeding.Seeders.Core;

public class LectorsSeeder : BaseSeeder<Lector>
{
    public LectorsSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {

        #region Lectors
        //var cryptoCourse_firstLector = new Lector
        //{
        //    User = cryptoCourse_firstAdmin,
        //    Groups = new Group[] { cryptoCourse_foundamentalsGroup, cryptoCourse_altcoinsGroup },            
        //};
        //var cryptoCourse_secondLector = new Lector
        //{
        //    User = cryptoCourse_secondAdmin,
        //    Groups = new Group[] { cryptoCourse_foundamentalsGroup, cryptoCourse_altcoinsGroup, cryptoCourse_stableCoinsGroup },
        //};

        //var selfImprovementCourse_firstLector = new Lector
        //{
        //    User = cryptoCourse_firstAdmin,
        //    Groups = new Group[] { selfImprovementCourse_coldShowersGroup, selfImprovementCourse_fitnessGroup },
        //};
        //var selfImprovementCourse_secondLector = new Lector
        //{
        //    User = cryptoCourse_firstAdmin,
        //    Groups = new Group[] { selfImprovementCourse_coldShowersGroup, selfImprovementCourse_fitnessGroup, selfImprovementCourse_meditationGroup},
        //};
        #endregion


        // dataToSeed = new[] { cryptoCourse, selfImprovementCourse };        
    }
}