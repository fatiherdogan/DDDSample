﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.InfrastructureLayer.Repositories
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class
    {
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity Find(TKey id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TKey id);

    }
}