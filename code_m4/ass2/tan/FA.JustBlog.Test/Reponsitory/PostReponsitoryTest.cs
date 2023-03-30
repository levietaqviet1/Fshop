using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Test.Reponsitory
{
    [TestFixture]
    public class PostRepositoryTest : BaseTest
    {
        public PostRepositoryTest() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            _context.Database.EnsureDeleted();
        }
        [Test]
        public void GetAll_ListPost_WhenCall_ReturnValue()
        {
            // Arrge

            //Act
            var result = _postRepository.GetAll();
            //Assert
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void FindId_Post_WhenCall_ReturnObjetct()
        {
            // Arrge

            //Act
            var result = _postRepository.Find(3);
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateNewPost_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Post
            {
                Title = "The pandemic has changed consumer behaviour forever - and online shopping looks set to stay",
                ShortDescripion = "In total, 75% of US consumers have tried a new shopping behaviour and over a third of them (36%) have tried a new product brand. In part, this trend has been driven by popular items being out of stock as supply chains became strained at the height of the pandemic. However, 73% of consumers who had tried a different brand said they would continue to seek out new brands in the future.",
                PostContent = "The consulting and accounting firm's June 2021 Global Consumer Insights Pulse Survey reports a strong shift to online shopping as people were first confined by lockdowns, and then many continued to work from home.",
                UrlSlug = "the-pandemic-has-changed-consumer-behaviour-forever-and-online-shopping-looks-set-to-stay",
                Published = false,
                PostedOn = DateTime.Now,
                Modified = DateTime.Now,
                CategoryId = 2,
            };

            //Act
            _postRepository.Create(itemToAdd);

            //Assert
            var result = _postRepository.Find(itemToAdd.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateCategory_WhenCalled_ReturnsObject()
        {
            // Arrange

            // Act
            var result = _postRepository.Find(1);
            // Assert         
            _postRepository.Update(result);
        }

        [Test]
        public void DeleteCategory_WhenCalled_ReturnObject()
        {
            // Arrange

            // Act
            var result = _postRepository.Find(1);
            // Assert         
            _postRepository.Delete(result);
        }

    }
}
