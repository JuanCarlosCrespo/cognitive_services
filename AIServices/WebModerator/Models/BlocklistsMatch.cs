using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebModerator.Models
{
    /// <summary>
    /// Class representing a detailed detection result for a blocklist match.
    /// </summary>
    public class BlocklistsMatch
    {
        /// <summary>
        /// The name of the blocklist.
        /// </summary>
        public string? BlocklistName { get; set; }
        /// <summary>
        /// The ID of the block item that matched.
        /// </summary>
        public string? BlocklistItemId { get; set; }
        /// <summary>
        /// The text of the block item that matched.
        /// </summary>
        public string? BlocklistItemText { get; set; }
    }
}
