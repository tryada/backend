using Backend.Models.Entities;

namespace Backend.Repositories;

public interface IRepository<T_Entity> where T_Entity : BaseModel 
{
    T_Entity Get(int id);
    IEnumerable<T_Entity> GetAll();
    void Insert(T_Entity model);
    void Update(T_Entity model);
    void Delete(int id);
}