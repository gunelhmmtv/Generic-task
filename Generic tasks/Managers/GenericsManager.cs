using Generic_tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Managers
{
    public class GenericsManager<T> : IGenerics<T> where T : IProducts, new()
    {

        protected readonly List<T> _Products;

        public GenericsManager(List<T> values)
        {
            _Products = values;
        }

        public void Add(T product)
        {
            Console.WriteLine($"product id: {product.Id} product name:  {product.Name}, price: {product.Price}");
            _Products.Add(product);
            Console.WriteLine($" {product.Id}, {product.Name} {product.Price} Product added");
        }

        public T GetByID(int id)
        {
            T data = _Products[id];

            foreach (T item in _Products)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return data;
        }

        public IEnumerable<T> GetAll()
        {
            return _Products;
        }

        public void Remove(int id)
        {
            _Products.RemoveAt(id);
            Console.WriteLine($"{id} product deleted");
        }

        public void Update(int id, T product)
        {
            foreach (var item in _Products)
            {
                if (item.Id == id)
                {

                    item.Name = product.Name;
                    item.Price = product.Price;

                    
                }
            }
            Console.WriteLine("updated");
        }

        
    }
}
