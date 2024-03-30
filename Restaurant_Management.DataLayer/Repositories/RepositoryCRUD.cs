using Restaurant_Management.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataLayer.Repositories
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class RepositoryCRUD<T> where T : class
    {
        private RS_Model _context;
        private DbSet<T> _dbset;

        public RepositoryCRUD()
        {
            _context = new RS_Model();
            _dbset = _context.Set<T>();
        }
        

        public virtual List<T> GetAll()
        {
            return _dbset.ToList();
        }

        public virtual T GetById(object id)
        {
            return _dbset.Find(id);
        }

        public virtual void Insert(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbset.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _dbset.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }
        
        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
