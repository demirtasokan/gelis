using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProject.Models;
using Moq;
using SampleProject.Repository;
using SampleProject.Service.Concrete;
using SampleProject.Domain;
using AutoMapper;
using SampleProject.App_Start;

namespace SampleProject.Tests
{
    [TestClass]
    public class BookServiceTest
    {
        BookService bookService;
        Mock<IBookRepository> mockRepository ;
        Book book;
        BookDto bookDto;

        [TestCleanup]
        public void TestSetUp()
        {
            Mapper.Reset();
        }
        
        [TestInitialize]
        public void Initialize()
        {
          
            AutoMapperConfig.Configure();
            
            book = new Book
            {
                isbn = "1-2-311-213-11",
                name = "Turkey's Cities",
                publishdate = new DateTime(2018, 12, 12)
            };

            bookDto = new BookDto
            {
                Isbn = "1-2-311-213-11",
                Name = "Turkey's Cities",
                PublishDate = new DateTime(2018, 12, 12)
            };

            mockRepository = new Mock<IBookRepository>();
            bookService = new BookService(mockRepository.Object);

        }
          

        [TestMethod]
        public void ShouldReturnBookWhenBookFound()
        {
            int bookId = 1;

            mockRepository.Setup(x => x.Get(bookId)).Returns(book);
            var bookDto = bookService.Get(bookId);
            mockRepository.Verify(x => x.Get(1), Times.Once());

            Assert.AreEqual(book.name, bookDto.Name);
        }


        [TestMethod]
        public void KitapEklendigindeKitapEklenmeli()
        {

            mockRepository.Setup(x => x.Insert(It.IsAny<Book>())).Returns(It.IsAny<int>());
            var id = bookService.Insert(bookDto);

            mockRepository.Verify(x => x.Insert(It.IsAny<Book>()), Times.Once);
        }

       
        [TestMethod]
        public void KitapGuncellendigindeGuncellenmeli()
        {
            mockRepository.Setup(x => x.Update(It.IsAny<Book>())).Returns(true);
            var result = bookService.Update(bookDto);

            Assert.IsNotNull(result);
            mockRepository.Verify(x => x.Update(It.IsAny<Book>()), Times.Once);
        }


        [TestMethod]
        public void KitapSilindigindeSilinmeli()
        {
            mockRepository.Setup(x => x.Delete(It.IsAny<Book>())).Returns(true);
            var result = bookService.Delete(bookDto);

            Assert.IsTrue(result);
            mockRepository.Verify(x => x.Delete(It.IsAny<Book>()), Times.Once);
        }
           
        
    }
}
