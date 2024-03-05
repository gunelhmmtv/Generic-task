using Generic_tasks.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Managers
{
    public class DrinksManager : GenericsManager<Drinks>
    {
        public DrinksManager() : base(
            new List<Drinks>
            {
                new Drinks {Id=1,Name="Cola",Price=2},
                new Drinks {Id=2,Name="Ice Tea",Price=3},
                new Drinks {Id=3, Name = "Coffee", Price=5}
            })
            { }
    }
}
