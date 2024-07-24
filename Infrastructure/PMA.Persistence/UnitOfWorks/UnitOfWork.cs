using Microsoft.EntityFrameworkCore.Storage;
using PMA.Application.Interfaces.Repositories;
using PMA.Application.Interfaces.UnitOfWork;
using PMA.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        
        public ICategoryRepository CategoryRepository { get; }

        public IPlantRepository PlantRepository{ get; }


        public UnitOfWork(ApplicationDbContext context, ICategoryRepository categoryRepository, IPlantRepository plantRepository)
        {
            _context = context;
            CategoryRepository = categoryRepository;
            PlantRepository = plantRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();


        public async ValueTask DisposeAsync() { }


    }
}
