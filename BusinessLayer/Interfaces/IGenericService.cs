using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();
        T TGetById(int Id);
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
    }
}
