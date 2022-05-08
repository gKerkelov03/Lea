using Data.Entities.Core;
using Data.Interfaces.Core;

namespace Data.Repositories.Core;

public class LectorsRepository : BaseRepository<Lector>, ILectorsRepository
{
    public LectorsRepository(LeaDbContext context) : base(context)
    {
    }
}
