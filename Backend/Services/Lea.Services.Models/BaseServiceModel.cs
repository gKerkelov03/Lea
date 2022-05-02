namespace Lea.Services.Data.Models;

public class BaseServiceModel
{
    public Guid Id { get; set; }

    public BaseServiceModel() => Id = Guid.NewGuid();
}
