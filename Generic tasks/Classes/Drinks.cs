using Generic_tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Classes
{
    public class Drinks : IProducts
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public int Price {  get; set; }
    }
}
