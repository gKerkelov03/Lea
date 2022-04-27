using Lea.Data.Repositories;

namespace Lea.Data.Seeding.Seeders;

public class FoldersSeeder : BaseSeeder<FolderRepository>
{
    public FoldersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new FolderRepository[]
        {

        };
    }
}