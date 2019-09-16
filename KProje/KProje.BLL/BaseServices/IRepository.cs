﻿using KProje.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KProje.BLL.BaseServices
{
    public interface IRepository<T> 
    {
        void Insert(T entity);
        void Delete(object id);
        int Save();
        IEnumerable<T> GetList();
        IQueryable<T> GetListIQuerable();
        IEnumerable<T> GetList(Expression<Func<T, bool>> _lamda);
        T FirstOrDefault(Expression<Func<T, bool>> _lamda);
        bool Any(Expression<Func<T, bool>> _lamda);
    }
}
