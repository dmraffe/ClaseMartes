using Ecommerce.Application.Contract.Repository;
using Ecommerce.Infrastructure.Implementation.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure
{
    public static class RegisterInfrastructure
    {

        public static IServiceCollection RegisterInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EcommerceDbContext>(opt => 
              opt.UseSqlServer(configuration.GetConnectionString("ecommerce"))
            );
            services.AddScoped(typeof(IRepositoryAsync<>), typeof(BaseRepositoryAsync<>));
          return   services;
        }
    }
}
