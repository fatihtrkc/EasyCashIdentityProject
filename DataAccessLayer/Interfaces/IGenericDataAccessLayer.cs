using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IGenericDataAccessLayer<T> where T : class
    {
        List<T> GetList();
        T GetById(int Id);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
    }
}
