using SampleProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        //IEnumerable<Book> GetBookByMultipleCondition(Expression<Func<Book, bool>> query);
    }
}
