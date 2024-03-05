using Generic_tasks.Classes;
using Generic_tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Managers
{
    public class DesertsManager : GenericsManager<Deserts>
    {


        public DesertsManager() : base(
        new List<Deserts>
            {
            new Deserts { Id=1,Name="Brownie",Ingridients="ice cream",Price=4},
            new Deserts { Id=2,Name="Pie",Ingridients="apple",Price=2},
            new Deserts { Id=3,Name="Cheesecake",Ingridients = "cherry", Price=5}
            })
        {
        }
    }
}
 
