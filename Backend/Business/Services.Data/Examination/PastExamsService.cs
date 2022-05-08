using AutoMapper;

namespace Services.Data.Examination;

public class PastTestsService : BaseDataService<PastExam, PastExamServiceModel, PastTestsRepository>, IPastExamsService
{
    public PastTestsService(PastTestsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
