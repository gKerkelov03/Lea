using Data.Entities.Core;
using Data.Interfaces.Core;

namespace Data.Repositories.Core;

public class StudentsRepository : BaseRepository<Student>, IStudentsRepository
{
    public StudentsRepository(LeaDbContext context) : base(context)
    {
    }
}
