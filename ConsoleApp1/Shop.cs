using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Moto> Motorcycles { get; set; }

    }
}
