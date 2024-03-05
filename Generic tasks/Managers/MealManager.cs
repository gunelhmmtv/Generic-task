using Generic_tasks.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Managers
{
    public class MealManager : GenericsManager<Meals>
    {
        public MealManager() : base(
            new List<Meals>
            { new Meals{Id=1,Name="Noodles",Ingridients="Chicken",Price=12 },
              new Meals{Id=1,Name="Fettuccine",Ingridients="Mushroom",Price=15 },
              new Meals{Id=1,Name="Rice",Ingridients="Salmon",Price=10 }

            })
        {
        }
    }
}
