using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MotoDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MotoDbContext>
    {
        protected override void Seed(MotoDbContext context)
        {
           var OnlinerMotos = new List<Moto>()
            {
                new Moto(){Make = "Honda", Name = "Transalp", Year = 1991, Price = 1800},
                new Moto(){Make = "Honda", Name = "Gold Wing", Year = 1995, Price = 4000},
                new Moto(){Make = "Suzuki", Name = "Bandit", Year = 1999, Price = 2700},
                new Moto(){Make = "Minsk", Name = "XC250", Year = 2019, Price = 1300},
                new Moto(){Make = "Minsk", Name = "D4", Year = 2019, Price = 900},
                new Moto(){Make = "BMW", Name = "R 1200 GS", Year = 2018, Price = 22000},
                new Moto(){Make = "Yamaha", Name = "R1", Year = 2009, Price = 8000},

            };
            var onliner = new Shop { Name = "Onliner", Motorcycles = OnlinerMotos };

            var AvMotos = new List<Moto>()
            {
                new Moto(){Make = "Honda", Name = "Transalp", Year = 1994, Price = 2000},
                new Moto(){Make = "Honda", Name = "Gold Wing", Year = 2007, Price = 11000},
                new Moto(){Make = "Ktm", Name = "Duke", Year = 2012, Price = 4700},
                new Moto(){Make = "Minsk", Name = "XC250", Year = 2017, Price = 1200},
                new Moto(){Make = "Minsk", Name = "D4", Year = 2015, Price = 800},
                new Moto(){Make = "Ducatti", Name = "Diavel", Year = 2018, Price = 25000},
                new Moto(){Make = "Harley Davidson", Name = "Dyna Electra Glide", Year = 2009, Price = 14000},

            };
            var av = new Shop { Name = "Av.by", Motorcycles = AvMotos };
            context.Shops.Add(onliner);
            context.Shops.Add(av);
            context.SaveChanges();
            
        }
    }

}
