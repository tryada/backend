using Backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories;

public interface IRepositoryContext
{
    DbSet<BikeModel> BikeDbSet { get; set; }
    void Save();
}