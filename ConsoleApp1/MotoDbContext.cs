using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MotoDbContext : DbContext
    {
        public MotoDbContext() : base("DBConnection")
        {
        }

        public DbSet<Moto> Motos { get; set; }
        public DbSet<Shop> Shops { get; set; }
    }
}
