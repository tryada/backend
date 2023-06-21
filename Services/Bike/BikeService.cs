using AutoMapper;
using Backend.Contract;
using Backend.Models.Entities;
using Backend.Repositories;

namespace Backend.Services;

public class BikeService : IBikeService
{
    IBikeRepository bikeRepository;
    IMapper mapper;

    public BikeService(IBikeRepository bikeRepository, IMapper mapper)
    {
        this.bikeRepository = bikeRepository;
        this.mapper = mapper;
    }

    public BikeDto GetSingle(int id)
    {
        var model = bikeRepository.Get(id);
        return mapper.Map<BikeDto>(model);
    }

    public IEnumerable<BikeDto> GetAll()
    {
        var models = bikeRepository.GetAll();
        return models.Select(mapper.Map<BikeDto>);
    }

    public IEnumerable<BikeDto> GetFiltered(BikeFilterParamDto filterParameters)
    {
        var models = bikeRepository.GetFiltered(filterParameters);
        return models.Select(mapper.Map<BikeDto>);
    }

    public void Insert(BikeDto dto)
    {
        // todo: walidacja
        var model = mapper.Map<BikeModel>(dto);
        bikeRepository.Insert(model);
    }

    public void Update(BikeDto dto)
    {
        // todo: walidacja
        var model = mapper.Map<BikeModel>(dto);
        bikeRepository.Update(model);
    }

    public void Delete(int id)
    {
        bikeRepository.Delete(id);
    }
}