using Backend.Models;

namespace Backend.Contract;

public class BikeDto
{
    public int Id { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public string Description { get; set; }
    public DateTime BoughtDate { get; set; }
    public BikeTypeEnum Type { get; set; }
    public float Price { get; set; }
    public bool IsNew { get; set; }
}