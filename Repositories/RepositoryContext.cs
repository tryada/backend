using Backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories;

public class RepositoryContext : DbContext, IRepositoryContext
{
    public DbSet<BikeModel> BikeDbSet { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

    public void Save()
    {
        this.SaveChanges();
    }
}