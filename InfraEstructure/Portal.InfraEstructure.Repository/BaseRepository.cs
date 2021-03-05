using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Portal.InfraEstructure.Entity.Context.Interfaces;
using Portal.InfraEstructure.Repository.Interfaces;
using Portal.Model;

namespace Portal.InfraEstructure.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntityModel
    {
        private readonly IPortalContext _portalContext;

        public BaseRepository(IPortalContext portalContext) =>
            _portalContext = portalContext;

        public virtual void Delete(TEntity entity) => 
            _portalContext.Remove(entity);

        public virtual TEntity Find(TEntity entity) => 
            _portalContext.Set<TEntity>().FirstOrDefault(t => t == entity);

        public virtual void Insert(TEntity entity) => 
            _portalContext.Add(entity);

        public virtual List<TEntity> Select(Expression<Func<TEntity, bool>> Predicate) => 
            _portalContext.Set<TEntity>().Where(Predicate).ToList();

        public virtual void Update(TEntity entity) => 
            _portalContext.Update(entity);
    }
}
