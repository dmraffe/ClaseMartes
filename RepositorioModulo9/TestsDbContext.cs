using Microsoft.EntityFrameworkCore;
using ModeloModulo9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioModulo9
{
    public class TestsDbContext : DbContext
    {
        public TestsDbContext(DbContextOptions<TestsDbContext> options) : base(options) { 
        
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
