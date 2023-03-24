using FA.BookStore.Core.Models;

namespace FA.BookStore.Test.ReponsitoryTest
{
    public class BookReponsitoryTest : BookStoreTest
    {
        public BookReponsitoryTest() : base()
        {

        }
        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }
        [Test]
        public void GetAllBooks_WhenCalled_ReturnValue()
        {
            //Arrange

            //Act
            var result = bookRepository.GetAll();

            //Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void FindBookId_WhenCalled_ReturnObject()
        {
            //Act
            var result = bookRepository.Find(1);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateNewBook_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Book
            {
                Title = "Test",
                CategoryId = 1,
                AuthorId = 1,
                PublisherId = 1,
                Summary = "Test",
                ImgUrl = "Test",
                Price = 10000,
                Quantity = 1,
                CreateDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsActive = true,
            };

            //Act
            bookRepository.Create(itemToAdd);

            //Assert
            var result = bookRepository.Find(itemToAdd.BookId);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateBookExits_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemUpdate = new Book
            {
                Title = "Test",
                CategoryId = 1,
                AuthorId = 1,
                PublisherId = 1,
                Summary = "Test",
                ImgUrl = "Test",
                Price = 10000,
                Quantity = 1,
                CreateDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsActive = true,
            };
            bookRepository.Create(itemUpdate);
            //Act
            bookRepository.Update(itemUpdate);

            //Assert
            var result = bookRepository.Find(6);
            Assert.That(result, Is.EqualTo(itemUpdate));
        }

        [Test]
        public void DeleteBookExits_WhenCalled_ReturnObject()
        {
            // Arrange
            var itemToDelete = new Book
            {
                Title = "Test",
                CategoryId = 1,
                AuthorId = 1,
                PublisherId = 1,
                Summary = "Test",
                ImgUrl = "Test",
                Price = 10000,
                Quantity = 1,
                CreateDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsActive = true,
            };
            bookRepository.Create(itemToDelete);
            // Act
            bookRepository.Delete(itemToDelete.BookId);

            // Assert
            var result = bookRepository.Find(6);
            Assert.IsNull(result);
        }
    }
}
