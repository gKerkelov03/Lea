using AutoMapper;
using Lea.Data.Entities.Secondary;
using Lea.Data.Repositories.Secondary;
using Lea.Services.Data.Interfaces.Secondary;
using Lea.Services.Data.Models.Secondary;

namespace Lea.Services.Data.Secondary;

public class TestQuestionsService : BaseDataService<TestQuestion, TestQuestionServiceModel, TestQuestionsRepository>, ITestQuestionsService
{
    public TestQuestionsService(TestQuestionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
