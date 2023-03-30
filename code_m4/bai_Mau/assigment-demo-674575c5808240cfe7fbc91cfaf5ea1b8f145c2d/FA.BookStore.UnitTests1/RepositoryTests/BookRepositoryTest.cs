using FA.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.UnitTests1.RepositoryTests
{
    [TestFixture]
    public class BookRepositoryTest:BaseTest
    {
        public BookRepositoryTest():base()
        {

        }

        [Test]
        public void GetAll_ListBooks_ReturnValue()
        {
            // Arrage
            var books = new List<Book>()
            {
                new Book
                {
                    BookId = 1,
                    Title = "Book 1",
                    CategoryId = 1
                },
                new Book
                {
                    BookId = 2,
                    Title = "Book 2",
                    CategoryId = 1
                }
            };

            bookRepsitoryMock.Setup(x => x.GetAll()).Returns(books);
            //bookRepository = bookRepsitoryMock.Object;

            uowMock.Setup(x => x.BookRepository).Returns(bookRepsitoryMock.Object);
            uow = uowMock.Object;
            // Act
            var result = uow.BookRepository.GetAll();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
        }
    }
}
