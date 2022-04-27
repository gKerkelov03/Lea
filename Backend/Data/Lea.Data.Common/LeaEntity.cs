namespace Lea.Data.Common;

// that is here only because of circular dependency otherwise, the whole project Lea.Data.Common exists for the same reason
public class LeaEntity 
{
    public Guid Id { get; set; }

    public LeaEntity()
    {
        this.Id = Guid.NewGuid();
    }
}
