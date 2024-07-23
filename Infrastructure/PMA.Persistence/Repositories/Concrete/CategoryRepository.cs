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
    internal class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
