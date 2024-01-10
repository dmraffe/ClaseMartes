using CRUD.ENTITY.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.ENTITY.Persistencia
{
    public class CrudDbContext : DbContext
    {


        public CrudDbContext(DbContextOptions<CrudDbContext> options) :  base(options) { 
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Persona> Personas { get; set; }


    }
}
