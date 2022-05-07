using Lea.Data.Entities.Examination;
using Lea.Data.Interfaces.Examination;

namespace Lea.Data.Repositories.Examination;

public class FoldersRepository : BaseRepository<Folder>, IFoldersRepository
{
    public FoldersRepository(LeaDbContext context) : base(context)
    {
    }
}
