using Microsoft.EntityFrameworkCore.Storage;
using PMA.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        public ICategoryRepository CategoryRepository { get; }
        public IPlantRepository PlantRepository { get; }
    }
}
