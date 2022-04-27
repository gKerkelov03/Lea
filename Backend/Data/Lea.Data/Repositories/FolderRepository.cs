using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class FolderRepository : BaseRepository<Folder>, IFolderRepository
{
    public FolderRepository(LeaDbContext context) : base(context)
    {
    }
}
