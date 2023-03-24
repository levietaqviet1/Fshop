using FA.BookStore.Core.Models;

namespace FA.BookStore.Test.ReponsitoryTest
{
    [TestFixture]
    public class PublisherRepositoryTest : BookStoreTest
    {
        public PublisherRepositoryTest() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }
        [Test]
        public void GetAllPublisher_WhenCalled_ReturnValue()
        {
            //Arrange

            //Act
            var result = publisherRepository.GetAll();

            //Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void FindPublisher_WhenCalled_ReturnObject()
        {
            //Act
            var result = publisherRepository.Find(1);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateNewPublisher_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Publisher
            {
                Name = "Test Item",
                Description = "A test item for unit testing",
            };

            //Act
            publisherRepository.Create(itemToAdd);

            //Assert
            var result = publisherRepository.Find(itemToAdd.PublisherId);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdatePublisherExits_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemUpdate = new Publisher
            {
                Name = "Test item update",
                Description = "A test item for unit testing"
            };
            publisherRepository.Create(itemUpdate);
            //Act
            publisherRepository.Update(itemUpdate);

            //Assert
            var result = publisherRepository.Find(6);
            Assert.That(result, Is.EqualTo(itemUpdate));
        }

        [Test]
        public void DeletePublisherExits_WhenCalled_ReturnObject()
        {
            // Arrange
            var itemToDelete = new Publisher
            {
                Name = "Test item delete",
                Description = "A test item for unit testing"
            };
            publisherRepository.Create(itemToDelete);
            // Act
            publisherRepository.Delete(itemToDelete.PublisherId);

            // Assert
            var result = publisherRepository.Find(6);
            Assert.IsNull(result);
        }
    }
}
