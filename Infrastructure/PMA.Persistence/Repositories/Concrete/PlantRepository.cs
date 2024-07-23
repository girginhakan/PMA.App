using PMA.Application.Interfaces.Repositories;
using PMA.Domain.Entities;
using PMA.Persistence.Context;
using PMA.Persistence.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Persistence.Repositories.Concrete
{
    public class PlantRepository : Repository<Plant>, IPlantRepository
    {
        public PlantRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
