using KProje.DAL.Data.Context;
using KProje.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace KProje.BLL.BaseServices
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbContext _context;
        public GenericRepository()
        {
            _context = new ApplicationDbContext();
        }
        public void Insert(TEntity entity)
        {
            entity.IsActive = true;
            _context.Set<TEntity>().Add(entity);
        }
        public bool Any(Expression<Func<TEntity, bool>> _lamda)
        {
            return _context.Set<TEntity>().Any(_lamda);
        }

        public void Delete(object id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            if (entity != null)
            {
                entity.IsActive = false;
                entity.IsDeleted = true;
            }

        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> _lamda)
        {
            return _context.Set<TEntity>().FirstOrDefault(_lamda);
        }

        public IEnumerable<TEntity> GetList()
        {
            return _context.Set<TEntity>().Where(x=>x.IsActive&&!x.IsDeleted).AsEnumerable();
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> _lamda)
        {
            return _context.Set<TEntity>().Where(x => x.IsActive && !x.IsDeleted).Where(_lamda).AsEnumerable();
        }

        public IQueryable<TEntity> GetListIQuerable()
        {
            return _context.Set<TEntity>().Where(x => x.IsActive && !x.IsDeleted).AsQueryable();
        }

       

        public int Save()
        {
            return _context.SaveChanges();
        }

    }
}
