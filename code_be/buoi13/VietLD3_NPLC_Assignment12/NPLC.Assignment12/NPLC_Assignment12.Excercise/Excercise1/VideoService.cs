namespace NPLC.Assignment12.Exercises.Exercise1
{
    /// <summary>
    /// Provides methods for working with video files.
    /// </summary>
    public class VideoService
    {
        private IVideoRepository _repository;

        /// <summary>
        /// Initializes a new instance of the VideoService class.
        /// </summary>
        /// <param name="repository">An optional IVideoRepository implementation. If not specified, a new instance of VideoRepository will be used.</param>
        public VideoService(IVideoRepository repository = null)
        {
            _repository = repository ?? new VideoRepository();
        }

        /// <summary>
        /// Returns a CSV-formatted string of IDs for unprocessed videos.
        /// </summary>
        /// <returns>A string containing a comma-separated list of video IDs.</returns>
        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();
            var videos = _repository.GetUnprocessedVideos();
            foreach (var item in videos)
            {
                videoIds.Add(item.Id);
            }
            return String.Join(',', videoIds);
        }
    }

}
