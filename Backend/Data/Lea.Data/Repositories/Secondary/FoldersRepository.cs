using Lea.Data.Entities.Secondary;
using Lea.Data.Repositories.Interfaces.Secondary;

namespace Lea.Data.Repositories.Secondary;

public class FoldersRepository : BaseRepository<Folder>, IFoldersRepository
{
    public FoldersRepository(LeaDbContext context) : base(context)
    {
    }
}
