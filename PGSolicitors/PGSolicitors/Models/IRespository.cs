using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PGSolicitors.Models
{
    public interface IRespository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Create(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        void Save();
    }
}