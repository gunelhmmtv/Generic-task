using Generic_tasks.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Managers
{
    public class FastFoodsManager : GenericsManager<FastFoods>
    {
        public FastFoodsManager() : base(
            new List<FastFoods>
            {
            new FastFoods{Id=1,Name="Burger",Price=9},
            new FastFoods{Id=2,Name="Pizza",Price=13},
            new FastFoods{Id=3,Name="Taco",Price=10}
            })
        {
        }
    }
}
