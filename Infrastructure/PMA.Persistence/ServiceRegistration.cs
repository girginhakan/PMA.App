using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMA.Application.Interfaces.Repositories;
using PMA.Application.Interfaces.UnitOfWork;
using PMA.Persistence.Context;
using PMA.Persistence.Repositories.Concrete;
using PMA.Persistence.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection, IConfiguration configuration = null)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration?.GetConnectionString("PostgreConStr")));

            serviceCollection.AddTransient<ICategoryRepository, CategoryRepository>();
            serviceCollection.AddTransient<IPlantRepository, PlantRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
