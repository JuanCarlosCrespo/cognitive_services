using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModerator.Models
{
    /// <summary>
    /// Base class for detection result.
    /// </summary>
    public class DetectionResult
    {
        /// <summary>
        /// The detailed result for categories analysis.
        /// </summary>
        public List<CategoriesAnalysis>? CategoriesAnalysis { get; set; }
    }
}
