using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.UnitTests.RepositoryTests
{
    [TestFixture]
    public class CategoryRepositoryTests: BaseTest
    {
        public CategoryRepositoryTests():base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetAll_WhenCalled_ReturnValue()
        {
            //Arrange

            //Act
            var result = categoryRepository.GetAll();


            // Assert
            Assert.That(result.Count,Is.EqualTo(2));
        }

        [Test]
        public void Find_WhenCalled_ReturnObject()
        {
            var result = categoryRepository.Find(1);

            Assert.IsNotNull(result);
        }
    }
}
