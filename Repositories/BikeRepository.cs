using Backend.Contract;
using Backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories;

public class BikeRepository : BaseRepository<BikeModel>, IBikeRepository
{
    protected override IQueryable<BikeModel> Query => context.BikeDbSet.AsQueryable();
    protected override DbSet<BikeModel> DbSet => context.BikeDbSet;

    public BikeRepository(IRepositoryContext context) : base(context)
    {
    }

    public IEnumerable<BikeModel> GetFiltered(BikeFilterParamDto filterParamDto)
    {
        var query = Query;

        if (filterParamDto.OnlyNew)
        {
            query = query.Where(x => x.IsNew);
        }

        if (!string.IsNullOrWhiteSpace(filterParamDto.Description))
        {
            query = query.Where(x => x.Description.Contains(filterParamDto.Description));
        }

        if(filterParamDto.Type.HasValue) {
            query = query.Where(x => x.Type == filterParamDto.Type);
        }

        return query
            .ToList();
    }

}