using Data.Entities.Examination;
using Services.Data.Models.Examination;

namespace Business.Interfaces.Data.Examination;

public interface IUpcomingExamsService : IBaseDataService<UpcomingExam, UpcomingExamServiceModel>
{
}
