using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class TeacherRepository : BaseRepository<Lector>, ITeacherRepository
{
    public TeacherRepository(LeaDbContext context) : base(context)
    {
    }
}
