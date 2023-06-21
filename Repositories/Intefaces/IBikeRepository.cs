using Backend.Contract;
using Backend.Models.Entities;

namespace Backend.Repositories;

public interface IBikeRepository : IRepository<BikeModel> 
{
    IEnumerable<BikeModel> GetFiltered(BikeFilterParamDto filterParamDto);
}