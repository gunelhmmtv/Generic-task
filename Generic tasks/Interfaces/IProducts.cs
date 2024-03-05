using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tasks.Interfaces
{
    public interface IProducts
    {
        int Id { get; set; }
        string Name { get; set; }
        int Price { get; set; }
    }
}
