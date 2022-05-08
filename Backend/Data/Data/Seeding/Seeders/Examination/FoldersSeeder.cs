using Data.Entities.Examination;

namespace Data.Seeding.Seeders.Examination;

public class FoldersSeeder : BaseSeeder<Folder>
{
    public FoldersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new Folder[]
        {

        };
    }
}