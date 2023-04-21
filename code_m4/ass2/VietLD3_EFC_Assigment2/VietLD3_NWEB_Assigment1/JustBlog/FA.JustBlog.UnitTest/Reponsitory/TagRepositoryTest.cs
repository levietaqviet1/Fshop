using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Test.Reponsitory
{
    [TestFixture]
    public class TagRepositoryTest : BaseTest
    {
        public TagRepositoryTest() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            _context.Database.EnsureDeleted();
        }


        [Test]
        public void FindByTagId_WhenCall_ReturnObjetct()
        {
            // Arrge

            //Act
            var result = tagRepository.Find(2);
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void AddTag_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Tag
            {
                Name = "Entity Framework Core: DbContext\r\n",
                UrlSlug = "entity-framework-core-dbcontext",
                Description = "The DbContext class is an integral part of Entity Framework. An instance of DbContext represents a session with the database which can be used to query and save instances of your entities to a database. DbContext is a combination of the Unit Of Work and Repository patterns",
                Count = 1,
            };

            //Act
            tagRepository.Add(itemToAdd);

            //Assert
            var result = tagRepository.Find(itemToAdd.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateTag_WhenCalled_ReturnsObject()
        {
            // Arrange

            // Act
            var result = tagRepository.Find(2);
            result.Name = "d";
            // Assert         
            tagRepository.Update(result);
            Assert.That(result.Name, Is.EqualTo(tagRepository.Find(2).Name));
        }

        [Test]
        public void DeleteTagByTag_WhenCalled_ReturnObject()
        {
            // Arrange

            // Act
            var result = tagRepository.Find(3);
            // Assert         
            tagRepository.Delete(result);
            result = tagRepository.Find(3);
            Assert.IsNull(result);
        }

        [Test]
        public void DeleteTagByTagId_WhenCalled_ReturnObject()
        {
            // Arrange

            // Act 

            // Assert         
            tagRepository.Delete(1);
            var result = tagRepository.Find(1);
            Assert.IsNull(result);
        }

        [Test]
        public void GetAllTag_WhenCall_ReturnAllTag()
        {
            // Arrge

            //Act
            var result = tagRepository.GetAll();
            //Assert
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void GetTagByUrlSlug_WhenCall_ReturnObject()
        {
            // Arrge

            //Act
            var urlSlug = "saving-data-in-connected-scenario-in-ef-core";
            var result = tagRepository.GetTagByUrlSlug(urlSlug);
            //Assert
            Assert.IsNotNull(result);
        }

    }
}
