using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModerator.Models
{
    /// <summary>
    /// Exception raised when there is an error in detecting the content.
    /// </summary>
    public class DetectionException : Exception
    {
        public string Code { get; set; }

        /// <summary>
        /// Constructor for the DetectionException class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">The error message.</param>
        public DetectionException(string code, string message) : base(message)
        {
            Code = code;
        }
    }
}
