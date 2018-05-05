using Krd4.Models;
using System.Collections.Generic;

namespace Krd4.Services.Interfaces
{
    public interface IService<T> where T: BaseModel
    {
        void Add(T model);

        IEnumerable<T> GetAll();

        void Delete(int id);

        T GetById(int id);
    }
}
