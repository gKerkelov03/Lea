using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class AnswerOptionRepository : BaseRepository<Group>, IAnswerOptionRepository
{
    public AnswerOptionRepository(LeaDbContext context) : base(context)
    {
    }
}
