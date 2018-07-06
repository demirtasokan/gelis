using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Domain;
using Dapper;
using Npgsql;
using System.Data;
using System.Linq.Expressions;

namespace SampleProject.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {        
        public BookRepository(IDbConnection _connection) : base(_connection)
        {
           
        }
       
    }
}