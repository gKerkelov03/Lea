using AutoMapper;
using Lea.Data.Entities.Tests;
using Lea.Data.Repositories.Tests;
using Lea.Services.Data.Interfaces.Tests;
using Lea.Services.Data.Models.Tests;

namespace Lea.Services.Data.Tests;

public class UpcomingTestService : BaseDataService<UpcomingTest, UpcomingTestServiceModel, UpcomingTestsRepository>, IUpcomingTestsService
{
    public UpcomingTestService(UpcomingTestsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
