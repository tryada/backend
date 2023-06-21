using Backend.Models;

namespace Backend.Contract;

public class BikeFilterParamDto
{
    public bool OnlyNew { get; set; }
    public BikeTypeEnum? Type { get; set; }
    public string Description { get; set; }
}