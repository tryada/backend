using Backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories;

public abstract class BaseRepository<T_Entity> where T_Entity : BaseModel
{
    protected IRepositoryContext context;

    protected abstract IQueryable<T_Entity> Query { get; }
    protected abstract DbSet<T_Entity> DbSet { get; }

    public BaseRepository(IRepositoryContext context)
    {
        this.context = context;
    }

    public T_Entity Get(int id)
    {
        return Query
            .Where(x => x.Id == id)
            .SingleOrDefault();
    }

    public IEnumerable<T_Entity> GetAll()
    {
        return Query
            .ToList();
    }

    public void Insert(T_Entity model)
    {
        DbSet.Add(model);
        context.Save();
    }

    public void Update(T_Entity model)
    {
        DbSet.Update(model);
        context.Save();
    }

    public void Delete(int id)
    {
        var toRemove = Query.SingleOrDefault(x => x.Id == id);
        if (toRemove == null)
            return;

        DbSet.Remove(toRemove);
        context.Save();
    }
}