using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC.Assignment12.Exercises.Exercise1
{
    /// <summary>
    /// Represents a video file.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// Gets or sets the unique identifier of the video.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the video has been processed.
        /// </summary>
        public bool IsProcessed { get; set; }
    }

}
