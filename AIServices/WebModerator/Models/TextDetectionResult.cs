using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModerator.Models
{
    /// <summary>
    /// Class representing a text detection result.
    /// </summary>
    public class TextDetectionResult : DetectionResult
    {
        /// <summary>
        /// The list of detailed results for blocklist matches.
        /// </summary>
        public List<BlocklistsMatch>? BlocklistsMatch { get; set; }
    }
}
