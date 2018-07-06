using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Service.Contracts
{
    public interface IBookService : IService<BookDto>
    {
        //BookDto GetByPublishDate(DateTime? publishDate);

        //IEnumerable<BookDto> GetBookByMultipleCondition(BookDto bookDto);
    }
}
