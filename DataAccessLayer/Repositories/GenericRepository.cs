using DataAccessLayer.Concrete;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDataAccessLayer<T> where T : class
    {
        public List<T> GetList()
        {
            using var db = new EasyCashIdentityContext();
            return db.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            using var db = new EasyCashIdentityContext();
            return db.Set<T>().Find(Id);
        }

        public void Add(T t)
        {
            using var db = new EasyCashIdentityContext();
            db.Set<T>().Add(t);
        }

        public void Delete(T t)
        {
            using var db = new EasyCashIdentityContext();
            db.Set<T>().Remove(t);
            db.SaveChanges();
        }

        public void Update(T t)
        {
            using var db = new EasyCashIdentityContext();
            db.Set<T>().Update(t);
        }
    }
}
