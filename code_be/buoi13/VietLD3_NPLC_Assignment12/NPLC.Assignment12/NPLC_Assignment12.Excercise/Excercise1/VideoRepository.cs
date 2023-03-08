namespace NPLC.Assignment12.Exercises.Exercise1
{
    /// <summary>
    /// Defines methods for accessing video data from a data store.
    /// </summary>
    public interface IVideoRepository
    {
        /// <summary>
        /// Gets a collection of unprocessed videos.
        /// </summary>
        /// <returns>An IEnumerable of Video objects representing the unprocessed videos.</returns>
        IEnumerable<Video> GetUnprocessedVideos();
    }

    /// <summary>
    /// Implements the IVideoRepository interface using the VideoContext data store.
    /// </summary>
    public class VideoRepository : IVideoRepository
    {
        /// <summary>
        /// Gets a collection of unprocessed videos from the VideoContext data store.
        /// </summary>
        /// <returns>An IEnumerable of Video objects representing the unprocessed videos.</returns>
        public IEnumerable<Video> GetUnprocessedVideos()
        {
            using (var context = new VideoContext())
            {
                var videos = (from video in context.Videos where !video.IsProcessed select video).ToList();
                return videos;
            }
        }
    }

}
