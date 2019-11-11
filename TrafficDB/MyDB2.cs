using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficDB
{
    public class MyDB2:DbContext
    {
        public MyDB2() : base(@"Data Source=DESKTOP-IQHUI0O\SQLEXPRESS;Initial Catalog=MyDB2;Integrated Security=True") { }
        public DbSet<Lamb> Lambs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
