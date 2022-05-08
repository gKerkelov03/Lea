namespace Data.Seeding;

public class BaseSeeder<TEntity> : ISeeder where TEntity : class
{
    private readonly LeaDbContext dbContext;

    protected TEntity[] dataToSeed;

    public BaseSeeder(LeaDbContext dbContext)
        => this.dbContext = dbContext;

    public virtual async Task SeedAsync()
    {
        foreach (var entity in dataToSeed)
        {
            dbContext.Set<TEntity>().Add(entity);
        }

        await dbContext.SaveChangesAsync();
    }
}
