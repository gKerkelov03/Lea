using AutoMapper;

namespace Services.Data.Examination;

public class UpcomingTestService : BaseDataService<UpcomingExam, UpcomingExamServiceModel, UpcomingExamsRepository>, IUpcomingExamsService
{
    public UpcomingTestService(UpcomingExamsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
