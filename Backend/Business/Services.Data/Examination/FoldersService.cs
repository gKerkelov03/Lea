using AutoMapper;

namespace Services.Data.Examination;

public class FoldersService : BaseDataService<Folder, FolderServiceModel, FoldersRepository>, IFoldersService
{
    public FoldersService(FoldersRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
