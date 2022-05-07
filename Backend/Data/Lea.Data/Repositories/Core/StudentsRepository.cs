using Lea.Data.Entities.Core;
using Lea.Data.Interfaces.Core;

namespace Lea.Data.Repositories.Core;

public class StudentsRepository : BaseRepository<Student>, IStudentsRepository
{
    public StudentsRepository(LeaDbContext context) : base(context)
    {
    }
}
