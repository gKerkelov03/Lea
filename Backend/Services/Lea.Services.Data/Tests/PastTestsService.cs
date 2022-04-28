using AutoMapper;
using Lea.Data.Entities.Tests;
using Lea.Data.Repositories.Tests;
using Lea.Services.Data.Interfaces.Tests;
using Lea.Services.Data.Models.Tests;

namespace Lea.Services.Data.Tests;

public class PastTestsService : BaseDataService<PastTest, PastTestServiceModel, PastTestsRepository>, IPastTestsService
{
    public PastTestsService(PastTestsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
