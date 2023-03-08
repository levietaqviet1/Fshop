using System.Net;

namespace NPLC.Assignment12.Exercises.Exercise2
{
    public class InstallHelper
    {
        private readonly IFileDownloader _fileDownloader;
        private string _setupDestinationFile;

        public InstallHelper(IFileDownloader fileDownloader)
        {
            _fileDownloader = fileDownloader;
        }

        /// <summary>
        /// Downloads an installer for the specified customer and installer name.
        /// </summary>
        /// <param name="customerName">The name of the customer for whom the installer is being downloaded.</param>
        /// <param name="installerName">The name of the installer to download.</param>
        /// <returns>true if the download is successful; otherwise, false.</returns>
        public bool DownloadInstaller(string customerName, string installerName)
        {
            try
            {
                // Construct the URL for the installer using the customer name and installer name.
                string url = string.Format("http://example.com/{0}/{1}", customerName, installerName);

                // Download the installer file to the destination file path.
                _fileDownloader.DownloadFile(url, _setupDestinationFile);

                // Return true to indicate that the download was successful.
                return true;
            }
            catch (WebException)
            {
                // If a WebException is thrown, return false to indicate that the download failed.
                return false;
            }
        }
    }

}
