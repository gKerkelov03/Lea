using Lea.Data.Entities.Examination;
using Lea.Data.Repositories.Examination;

namespace Lea.Data.Seeding.Seeders.Examination;

public class FoldersSeeder : BaseSeeder<Folder>
{
    public FoldersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new Folder[]
        {

        };
    }
}