using Moq;
using NPLC.Assignment12.Exercises.Exercise2;
using System.Net;

namespace NPLC.Assignment12.Exercises.UnitTests
{
    [TestFixture]
    public class InstallHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private InstallHelper _installerHelper;

        [SetUp]
        public void SetUp()
        {
            _fileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallHelper(_fileDownloader.Object);
        }

        /// <summary>
        /// Kiểm tra xác minh rằng DownloadInstaller trả về false khi tải xuống tệp không thành công
        /// </summary>
        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFalse()
        {
            // Arrange
            _fileDownloader.Setup(fd => fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();

            // Act
            var result = _installerHelper.DownloadInstaller("khach1", "name1");

            // Assert
            Assert.That(result, Is.False);
        }

        /// <summary>
        /// Kiểm tra xác minh rằng DownloadInstaller trả về true khi quá trình tải xuống tệp hoàn tất thành công
        /// </summary>
        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnsTrue()
        {
            // Act
            var result = _installerHelper.DownloadInstaller("khach2", "name2");

            // Assert
            Assert.That(result, Is.True);
        }

    }
}
