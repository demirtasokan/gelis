using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;
using SampleProject.Domain;
//using Dapper.Extensions.Linq.Builder;
//using Dapper.Extensions.Linq.Core;
//using DapperExtensions;

namespace SampleProject.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        
        IDbConnection _connection;

        public Repository(IDbConnection connection)
        {            
            _connection = connection;         
        }

        public T Get(long id)
        {

            return _connection.Get<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _connection.GetAll<T>();
        }

        public long Insert(T obj)
        {
            return _connection.Insert<T>(obj);
        }

        public long Insert(IEnumerable<T> list)
        {
            return _connection.Insert(list);
        }

        public bool Update(T obj)
        {
            var isSuccess = _connection.Update<T>(obj);
            return isSuccess;
        }

        public bool Update(IEnumerable<T> list)
        {
            var isSuccess = _connection.Update(list);
            return isSuccess;
        }

        public bool Delete(T obj)
        {
            var isSuccess = _connection.Delete<T>(obj);
            return isSuccess;
        }

        public bool Delete(IEnumerable<T> list)
        {
            var isSuccess = _connection.Delete(list);
            return isSuccess;
        }

        public bool DeleteAll()
        {
            var isSuccess = _connection.DeleteAll<T>();
            return isSuccess;
        }

     
    }
}