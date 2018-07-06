using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Service.Contracts
{
    
    public interface IService<T> where T : class
    {
        //IEnumerable<T> GetBy(object dto);
        T Get(long id);
        IEnumerable<T> GetAll();
        long Insert(T dto);
        long Insert(IEnumerable<T> dtoList);
        bool Update(T dto);
        bool Update(IEnumerable<T> dtoList);
        bool Delete(T dto);
        bool Delete(IEnumerable<T> dtoList);
        bool DeleteAll();
    }
}
