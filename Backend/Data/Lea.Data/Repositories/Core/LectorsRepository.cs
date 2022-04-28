using Lea.Data.Entities.Core;
using Lea.Data.Repositories.Interfaces.Core;

namespace Lea.Data.Repositories.Core;

public class LectorsRepository : BaseRepository<Lector>, ILectorsRepository
{
    public LectorsRepository(LeaDbContext context) : base(context)
    {
    }
}
