using Moq;
using NPLC.Assignment12.Exercises.Exercise1;

namespace NPLC.Assignment12.Exercises.UnitTests
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IVideoRepository> _repository;
        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IVideoRepository>();
            _videoService = new VideoService(_repository.Object);
        }

        [Test]
        public void GetUnprocessedVideoAsCsv_AllVideoAreProcessed_ReturnAnEmptyString()
        {
            // Arrange
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>());
            // Action
            var result = _videoService.GetUnprocessedVideosAsCsv();

            // Assert
            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void getunprocessedvideosascsv_AFewUnprocessedVideos_ReturnsAStringWithIdOfUnprocessedVideos()
        {
            // Arrange
            _repository.Setup(vr => vr.GetUnprocessedVideos())
                .Returns(new List<Video>
                {
                new Video { Id = 1, IsProcessed = false },
                new Video { Id = 2, IsProcessed = false },
                new Video { Id = 3, IsProcessed = false },
                 new Video { Id = 4, IsProcessed = false }
                });

            // Action
            var result = _videoService.GetUnprocessedVideosAsCsv();

            // Assert
            Assert.That(result, Is.EqualTo("1,2,3,4"));
        }
    }
}