using Lea.Data.Entities;
using Lea.Data.Repositories.Contracts;

namespace Lea.Data.Repositories;

public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
{
    public QuestionRepository(LeaDbContext context) : base(context)
    {
    }
}
