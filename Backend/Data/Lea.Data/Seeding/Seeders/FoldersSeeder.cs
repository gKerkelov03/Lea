using Lea.Data.Repositories.Examination;

namespace Lea.Data.Seeding.Seeders;

public class FoldersSeeder : BaseSeeder<FoldersRepository>
{
    public FoldersSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider) : base(dbContext, serviceProvider)
    {
        dataToSeed = new FoldersRepository[]
        {

        };
    }
}