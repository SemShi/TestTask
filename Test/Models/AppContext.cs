using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entityes;
using System.Data.Entity;

namespace Test.Models
{
    internal class AppContext : DbContext
    {
        public DbSet<Apartments> apartments { get; set; }
        public DbSet<Cities> cities { get; set; }
        public DbSet<Houses> houses { get; set; }
        public DbSet<Streets> streets { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
