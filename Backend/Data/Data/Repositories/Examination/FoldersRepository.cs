using Data.Entities.Examination;
using Data.Interfaces.Examination;

namespace Data.Repositories.Examination;

public class FoldersRepository : BaseRepository<Folder>, IFoldersRepository
{
    public FoldersRepository(LeaDbContext context) : base(context)
    {
    }
}
