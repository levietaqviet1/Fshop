using System.Net;

namespace NPLC.Assignment12.Exercises.Exercise2
{
    public interface IFileDownloader
    {
        /// <summary>
        /// Downloads a file from the specified URL to the specified path.
        /// </summary>
        /// <param name="url">The URL of the file to download.</param>
        /// <param name="path">The path where the file should be saved.</param>
        void DownloadFile(string url, string path);
    }

    public class FileDownloader : IFileDownloader
    {
        /// <summary>
        /// Downloads a file from the specified URL to the specified path using the WebClient class.
        /// </summary>
        /// <param name="url">The URL of the file to download.</param>
        /// <param name="path">The path where the file should be saved.</param>
        public void DownloadFile(string url, string path)
        {
            var client = new WebClient();
            client.DownloadFile(url, path);
        }
    }

}
