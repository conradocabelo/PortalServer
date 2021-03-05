using Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Portal.InfraEstructure.Repository.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity: BaseEntityModel
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        TEntity Find(TEntity entity);
        List<TEntity> Select(Expression<Func<TEntity, bool>> Predicate);
    }
}
