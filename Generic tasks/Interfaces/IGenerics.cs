using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Interfaces
{
    public interface IGenerics<T> where T : IProducts, new()
    {
       
        T GetByID(int id);

        IEnumerable<T> GetAll();

        void Add(T product);
        void Remove(int id);
        void Update(int id, T product);
    }
}
