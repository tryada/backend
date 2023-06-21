using AutoMapper;
using Backend.Contract;
using Backend.Models.Entities;

namespace Backend.Models.Mappers;

public class BikeMapper : Profile
{
    public BikeMapper()
    {
        CreateMap<BikeModel, BikeDto>();
        CreateMap<BikeDto, BikeModel>();
    }
}