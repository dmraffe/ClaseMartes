using Ecommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options) { 
        
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries<TableBase>())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.Now;
                        item.Entity.CreatedByName = "system";
                        break;
                    case EntityState.Modified:
                        item.Entity.UpdateDate = DateTime.Now;
                        item.Entity.UpdateByName = "system";
                        break;
                }

            }
            return base.SaveChangesAsync(cancellationToken);
        }


        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orden> Ordens { get; set; }
        public DbSet<OrdenProduct> OrdenProducts { get; set; }
    }
}
