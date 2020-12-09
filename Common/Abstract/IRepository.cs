﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Common.Abstract
{
    public interface IRepository<T> where T : class , new()
    {

        //IQueryable<T> Include<T1>(Expression<Func<T, T1>> selector);

        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);
        T Get(int id);

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);
    }
}
