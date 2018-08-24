using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kellton.Models.Details
{
    public class MovieModel
    {
        public int movieId { get; set; }
        public string movieName { get; set; }
        public string releaseYear { get; set; }
        public string genre { get; set; }
    }
}
