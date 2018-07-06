
using log4net;
using SampleProject.Models;
using SampleProject.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace SampleProject.Controllers
{
    public class BookController : ApiController
    {
        private IBookService _bookService;

        
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
            

        }

        public IHttpActionResult Get(int id)
        {

            log4net.ILog log = log4net.LogManager.GetLogger("serverlogger");
            log.Info("info server log message");


            //var t = _bookService.GetBookByMultipleCondition(new BookDto { id = id });
            return Ok();
        }

        //public IHttpActionResult Get(int id)
        //{
        //    var t = _bookService.Get(id);
        //    return Ok(t);
        //}

        //[HttpPut]
        //public IHttpActionResult Put(BookDto bookDto)
        //{
        //    _bookService.Update(bookDto);
        //    return Ok(HttpStatusCode.OK);
        //}

        //[HttpPost]
        //public IHttpActionResult Post(BookDto bookDto)
        //{
        //    _bookService.Insert(bookDto);
        //    return Ok(HttpStatusCode.Created);
        //}

        //[HttpDelete]
        //public IHttpActionResult Delete(BookDto bookDto)
        //{
        //    _bookService.Delete(bookDto);
        //    return Ok(HttpStatusCode.NoContent);
        //}
    }
}
