using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Models;
using SampleProject.Repository;
using SampleProject.Service.Contracts;
using SampleProject.Domain;
using AutoMapper;


namespace SampleProject.Service.Concrete
{
    public class BookService : IBookService
    {
        IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        
        }

        //public IEnumerable<BookDto> GetBookByMultipleCondition(BookDto bookDto)
        //{
        //    Expression<Func<Book, bool>> filter = p => p.id == bookDto.id;

        //    var book =_bookRepository.GetBy(filter);
        //    return  Mapper.Map<IEnumerable<BookDto>>(book);
           

        //}

     

        //public BookDto GetByPublishDate(DateTime? publishDate)
        //{
        //    throw new NotImplementedException();
        //}

        public bool Delete(BookDto dto)
        {
            var book = Mapper.Map<Book>(dto);
            return _bookRepository.Delete(book);
            ;
        }

        public bool Delete(IEnumerable<BookDto> dtoList)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAll()
        {
            throw new NotImplementedException();
        }

        public BookDto Get(long id)
        {

            var book = _bookRepository.Get(id);
            var bookDto = Mapper.Map<BookDto>(book);
            return bookDto;
        }

        public IEnumerable<BookDto> GetAll()
        {
            var bookList = _bookRepository.GetAll();
            var bookDtoList = Mapper.Map<IEnumerable<BookDto>>(bookList);
            return bookDtoList;
        }

        //public BookDto GetByPublishDate(DateTime? publishDate)
        //{
        //    throw new NotImplementedException();
        //}

        public long Insert(BookDto dto)
        {
            var book = Mapper.Map<Book>(dto);
            return _bookRepository.Insert(book);
        }

        public long Insert(IEnumerable<BookDto> dtoList)
        {
            var bookList = Mapper.Map<IEnumerable<Book>>(dtoList);
            return _bookRepository.Insert(bookList);

        }

        public bool Update(BookDto dto)
        {
            var book = Mapper.Map<Book>(dto);
            return _bookRepository.Update(book);
        }

        public bool Update(IEnumerable<BookDto> dtoList)
        {
            throw new NotImplementedException();
        }
    }
}