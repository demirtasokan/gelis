using System.Collections.Generic;
using SampleProject.Domain;
using System.Collections;
using System.Linq.Expressions;
using System;

namespace SampleProject.Repository
{
   public interface IRepository<T> where T : BaseEntity 
    {

        T Get(long id);
        IEnumerable<T> GetAll();

        //IEnumerable<T> GetBy(Expression<Func<T,bool>> query);
        long Insert(T obj);
        long Insert(IEnumerable<T> list);
        bool Update(T obj);
        bool Update(IEnumerable<T> list);
        bool Delete(T obj);
        bool Delete(IEnumerable<T> list);
        bool DeleteAll();

    }
}
