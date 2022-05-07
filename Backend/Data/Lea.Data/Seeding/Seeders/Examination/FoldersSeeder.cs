using Lea.Data.Entities.Examination;

namespace Lea.Data.Seeding.Seeders.Examination;

public class FoldersSeeder : BaseSeeder<Folder>
{
    public FoldersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext)
    {
        dataToSeed = new Folder[]
        {

        };
    }
}