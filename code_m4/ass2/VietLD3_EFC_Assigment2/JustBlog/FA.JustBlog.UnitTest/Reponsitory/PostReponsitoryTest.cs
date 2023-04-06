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
        public void FindByYearAndMonthAndurlSlug_WhenCall_ReturnObjetct()
        {
            // Arrge

            //Act
            var result = postRepository.FindPost(2023, 02, "one-to-many-conventions-entity-framework-core");
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void FindByPostId_WhenCall_ReturnObjetct()
        {
            // Arrge

            //Act
            var result = postRepository.Find(1);
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void AddPost_WhenCalled_ReturnObject()
        {
            //Arrange
            var itemToAdd = new Post
            {
                Title = "First EF Core Console Application",
                ShortDescription = "Here you will learn how to use Entity Framework Core with Code-First approach step by step. To demonstrate this, we will create a .NET Core Console application using Visual Studio 17 (or greater).",
                PostContent = "The .NET Core Console application can be created either using Visual Studio 2017 or Command Line Interface (CLI) for .NET Core. Here we will use Visual Studio 2017.",
                UrlSlug = "entity-framework-core-console-application",
                Published = false,
                PostedOn = DateTime.Now,
                Modified = DateTime.Now,
                CategoryId = 1,
            };

            //Act
            postRepository.Add(itemToAdd);

            //Assert
            var result = postRepository.Find(itemToAdd.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdatePost_WhenCalled_ReturnsObject()
        {
            // Arrange

            // Act
            var result = postRepository.Find(1);
            result.Title = "tes";
            // Assert         
            postRepository.Update(result);
            var result2 = postRepository.Find(1);
            Assert.That(result.Title, Is.EqualTo(result2.Title));
        }

        [Test]
        public void DeletePostByPost_WhenCalled_ReturnObject()
        {
            // Arrange

            // Act
            var result = postRepository.Find(1);
            // Assert         
            postRepository.Delete(result);
            result = postRepository.Find(2);
            Assert.IsNull(result);

        }

        [Test]
        public void DeletePostByPostId_WhenCalled_ReturnObject()
        {
            // Arrange

            // Act 
            // Assert         
            postRepository.Delete(3);
            var result = postRepository.Find(3);
            Assert.IsNull(result);
        }

        [Test]
        public void GetAllPost_WhenCall_ReturnAllPost()
        {
            // Arrge

            //Act
            var result = postRepository.GetAll();
            //Assert
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void GetAllPostPublised_WhenCall_ReturnAllPost()
        {
            // Arrge

            //Act
            var result = postRepository.GetPublisedPosts();
            //Assert
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public void GetAllPostUnpublised_WhenCall_ReturnAllPost()
        {
            // Arrge

            //Act
            var result = postRepository.GetUnpublisedPosts();
            //Assert
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public void GetLateslPostBySize_WhenCall_ReturnAllPost()
        {
            // Arrge

            //Act
            var result = postRepository.GetLatestPost(2);
            //Assert
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void GetPostsByMonth_WhenCall_ReturnAllPost()
        {
            // Arrge

            //Act
            var result = postRepository.GetPostsByMonth(DateTime.Parse("2023-02-15"));
            //Assert
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public void CountPostForCategory_WhenCall_ReturnValue()
        {
            // Arrge

            //Act
            var result = postRepository.CountPostsForCategory("Entity Framework Core");
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }


        [Test]
        public void GetPostsByCategory_WhenCall_ReturnObject()
        {
            // Arrge

            //Act
            var result = postRepository.GetPostsByCategory("Entity Framework Core");
            //Assert
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void CountPostsForTag_WhenCall_ReturnValue()
        {
            // Arrge

            //Act
            var result = postRepository.CountPostsForTag("Querying in Entity Framework Core");
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetPostsForTag_WhenCall_ReturnObject()
        {
            // Arrge

            //Act
            var result = postRepository.GetPostsByTag("Querying in Entity Framework Core");
            //Assert
            Assert.That(result.Count, Is.EqualTo(1));
        }


    }
}
