using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Test.Reponsitory
{

    [TestFixture]
    public class CategoryRepositoryTest : BaseTest
    {
        public CategoryRepositoryTest() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            _context.Database.EnsureDeleted();
        }


        [Test]
        public void FindId_Category_WhenCall_ReturnObjetct()
        {
            // Arrge

            //Act
            var result = categoryRepository.Find(3);
            //Assert
            Assert.IsNotNull(result);
        }



        [Test]
        public void GetAll_ListCategory_WhenCall_ReturnValue()
        {
            // Arrge

            //Act
            var result = categoryRepository.GetAll();
            //Assert
            Assert.That(result.Count(), Is.EqualTo(2));
        }
        [Test]
        public void AddNewCategory_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Category
            {
                Name = "Querying in Entity Framework Core",
                UrlSlug = "querying-in-ef-core",
                Description = "Querying in Entity Framework Core remains the same as in EF 6.x, with more optimized SQL queries and the ability to include C#/VB.NET functions into LINQ-to-Entities queries.\r\n\r\n",
            };

            //Act
            categoryRepository.Add(itemToAdd);

            //Assert
            var result = categoryRepository.Find(itemToAdd.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateCategory_WhenCalled_ReturnsObject()
        {
            // Arrange

            // Act
            var result = categoryRepository.Find(3);
            result.Name = "test";
            // Assert         
            categoryRepository.Update(result);

            Assert.That(result.Name, Is.EqualTo(categoryRepository.Find(3).Name));
        }

        [Test]
        public void DeleteCategoryByObject_WhenCalled_ReturnObject()
        {
            // Arrange

            // Act
            var result = categoryRepository.Find(2);
            // Assert         
            categoryRepository.Delete(result);
            result = categoryRepository.Find(2);
            Assert.IsNull(result);
        }

        [Test]
        public void DeleteCategoryById_WhenCalled_ReturnObject()
        {
            // Arrange

            // Act

            // Assert         
            categoryRepository.Delete(1);
            var result = categoryRepository.Find(1);
            Assert.IsNull(result);
        }
    }


}
