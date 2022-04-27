namespace Lea.Data.Seeding;

public class BaseSeeder<TEntity> : ISeeder where TEntity : class
{
    private readonly LeaDbContext dbContext;
    private readonly IServiceProvider serviceProvider;

    protected TEntity[] dataToSeed;

    public BaseSeeder(LeaDbContext dbContext, IServiceProvider serviceProvider)
    {
        this.dbContext = dbContext;
        this.serviceProvider = serviceProvider;        
    }

    public virtual async Task SeedAsync()
    {
        foreach (var entity in this.dataToSeed)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        await dbContext.SaveChangesAsync();
    }
}
