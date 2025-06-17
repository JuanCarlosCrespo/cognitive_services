using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModerator.Models
{
    /// <summary>
    /// Class representing a detection error response.
    /// </summary>
    public class DetectionErrorResponse
    {
        /// <summary>
        /// The detection error.
        /// </summary>
        public DetectionError? error { get; set; }
    }
}
