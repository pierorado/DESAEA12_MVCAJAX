using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;
namespace Infraestructure
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name = DB_A63183_pierotecsup")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
