using AutoMapper;

namespace Services.Data.Core;

public class LectorsService : BaseDataService<Lector, LectorServiceModel, LectorsRepository>, ILectorsService
{
    public LectorsService(LectorsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
