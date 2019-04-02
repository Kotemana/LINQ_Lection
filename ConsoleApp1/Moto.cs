using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Moto : BaseEntity
    {
        public string Name { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }

        public void Report()
        {
            Console.WriteLine($"{Make} {Name} made in {Year} is {Price}$ worth. Sold in {Shop?.Name??"no shop"}");
        }
    }
}
