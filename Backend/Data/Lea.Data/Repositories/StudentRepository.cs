using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(LeaDbContext context) : base(context)
    {
    }
}
