using FA.BookStore.Core.Models;

namespace FA.BookStore.Test.ReponsitoryTest
{
    [TestFixture]
    public class CategoryReponsitoryTest : BookStoreTest
    {
        public CategoryReponsitoryTest() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }
        [Test]
        public void GetAllCategory_WhenCalled_ReturnValue()
        {
            //Arrange

            //Act
            var result = categoryRepository.GetAll();

            //Assert
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void FindCategoryId_WhenCalled_ReturnObject()
        {
            //Act
            var result = categoryRepository.Find(1);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateNewCategory_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Category
            {
                CategoryName = "Test Item",
                Description = "A test item for unit testing",
            };

            //Act
            categoryRepository.Create(itemToAdd);

            //Assert
            var result = categoryRepository.Find(itemToAdd.CategoryId);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateCategoryExits_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemUpdate = new Category
            {
                CategoryName = "Test item update",
                Description = "A test item for unit testing"
            };
            categoryRepository.Create(itemUpdate);
            //Act
            categoryRepository.Update(itemUpdate);

            //Assert
            var result = categoryRepository.Find(6);
            Assert.That(result, Is.EqualTo(itemUpdate));
        }

        [Test]
        public void DeleteCategoryExits_WhenCalled_ReturnObject()
        {
            // Arrange
            var itemToDelete = new Category
            {
                CategoryName = "Test item delete",
                Description = "A test item for unit testing"
            };
            categoryRepository.Create(itemToDelete);
            // Act
            categoryRepository.Delete(itemToDelete.CategoryId);

            // Assert
            var result = categoryRepository.Find(6);
            Assert.IsNull(result);
        }
    }
}
