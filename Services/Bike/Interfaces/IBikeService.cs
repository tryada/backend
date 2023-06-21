using Backend.Contract;

namespace Backend.Services;

public interface IBikeService 
{
    BikeDto GetSingle(int id);
    public IEnumerable<BikeDto> GetAll();
    public IEnumerable<BikeDto> GetFiltered(BikeFilterParamDto filterParameters);
    public void Insert(BikeDto dto);
    public void Delete(int id);
    public void Update(BikeDto dto);
}