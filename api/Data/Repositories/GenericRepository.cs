using api.Data.Repositories.Interfaces;
using api.Domain.Context;
using api.Domain.Interfaces;

namespace api.Data.Repositories;

public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
{
    protected readonly OnePieceDbContext OnePieceDbContext;

    public GenericRepository(OnePieceDbContext dbContext) => OnePieceDbContext = dbContext;

    public IEnumerable<TEntity> GetAll() => OnePieceDbContext.Set<TEntity>();

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await OnePieceDbContext.AddAsync(entity);
        await OnePieceDbContext.SaveChangesAsync();

        return entity;
    }
}