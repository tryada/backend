using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models.Entities;

[Table("Bike")]
public class BikeModel : BaseModel
{
    public int Year { get; set; }
    public string Model { get; set; }
    public string Description { get; set; }
    [Column(TypeName="date")] public DateTime BoughtDate { get; set; }
    public BikeTypeEnum Type { get; set; }
    public float Price { get; set; }
    public bool IsNew { get; set; }
}