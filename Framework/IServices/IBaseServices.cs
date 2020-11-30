﻿using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Qiushui.Lian.Bot.Framework
{
    public interface IBaseServices<TEntity> where TEntity:class
    {
        Task<TEntity> QueryById(object objId);
        Task<TEntity> QueryById(Expression<Func<TEntity, bool>> expression);
        Task<bool> DeleteById(object objId);
        Task<bool> DeleteById(Expression<Func<TEntity, bool>> expression);
        Task<bool> Insert(TEntity entity);
        Task<bool> Update(TEntity entity);
    }
}
