using AutoMapper;

namespace Services.Data.Messaging;

public class EmojisService : BaseDataService<Emoji, EmojiServiceModel, EmojisRepository>, IEmojisService
{
    public EmojisService(EmojisRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
