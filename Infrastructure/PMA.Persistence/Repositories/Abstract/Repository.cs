using Microsoft.EntityFrameworkCore;
using PMA.Application.Interfaces.Repositories;
using PMA.Domain.Common;
using PMA.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Persistence.Repositories.Abstract
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected ApplicationDbContext _dbContext;
        protected DbSet<TEntity> entities; 

        protected Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            entities= _dbContext.Set<TEntity>();
            _dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;
        }

        public int Create(TEntity entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            entities.Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
           entities.Remove(entity);
            return _dbContext.SaveChanges() ;
        }

        public ICollection<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return entities.SingleOrDefault(e=>e.Id==id);
        }

        public int Update(TEntity entity)
        {
            TEntity entityToUpdate = GetById(entity.Id);
            entity.CreatedDate=entityToUpdate.CreatedDate;
            entity.UpdatedDate=DateTime.UtcNow;
            return _dbContext.SaveChanges();
        }
    }
}
