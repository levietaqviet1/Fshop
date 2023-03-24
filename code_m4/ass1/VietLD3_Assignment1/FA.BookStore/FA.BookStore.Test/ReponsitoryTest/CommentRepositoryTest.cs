using FA.BookStore.Core.Models;

namespace FA.BookStore.Test.ReponsitoryTest
{
    [TestFixture]
    public class CommentRepositoryTest : BookStoreTest
    {
        public CommentRepositoryTest() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }
        [Test]
        public void GetAllComment_WhenCalled_ReturnValue()
        {
            //Arrange

            //Act
            var result = commentRepository.GetAll();

            //Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void FindComment_WhenCalled_ReturnObject()
        {
            //Act
            var result = commentRepository.Find(1);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateNewComment_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Comment
            {
                BookId = 1,
                Content = "Tett",
                CreatedDate = DateTime.Now,
                IsActice = true,
            };

            //Act
            commentRepository.Create(itemToAdd);

            //Assert
            var result = commentRepository.Find(itemToAdd.CommentId);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateCommentExits_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemUpdate = new Comment
            {
                BookId = 1,
                Content = "Tett",
                CreatedDate = DateTime.Now,
                IsActice = true,
            };
            commentRepository.Create(itemUpdate);
            //Act
            commentRepository.Update(itemUpdate);

            //Assert
            var result = commentRepository.Find(6);
            Assert.That(result, Is.EqualTo(itemUpdate));
        }

        [Test]
        public void DeleteCommentExits_WhenCalled_ReturnObject()
        {
            // Arrange
            var itemToDelete = new Comment
            {
                BookId = 1,
                Content = "Tett",
                CreatedDate = DateTime.Now,
                IsActice = true,
            };
            commentRepository.Create(itemToDelete);
            // Act
            commentRepository.Delete(itemToDelete.CommentId);

            // Assert
            var result = commentRepository.Find(6);
            Assert.IsNull(result);
        }
    }
}
