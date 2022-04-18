using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PGSolicitors.Models
{
    public class Repository<T> : IRespository<T> where T : class
    {
        private SDBContext db = null;
        private DbSet<T> dbSet = null;

        public Repository()
        {
            this.db = new SDBContext();
            dbSet = db.Set<T>();
        }

        public Repository(SDBContext context)
        {
            db = context;
            dbSet = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(int id, T entity)
        {
            T _entity = GetByID(id);
            db.Entry(_entity).CurrentValues.SetValues(entity);
        }

        public void Delete(int id)
        {
            T existing = dbSet.Find(id);
            dbSet.Remove(existing);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

