using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStarterBackend.Models
{
    public class TrackDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.TimeSpan Duration { get; set; }
        public System.DateTime DateTime { get; set; }
        public double Rating { get; set; }
        public string File { get; set; }

        public AuthorDTO Author { get; set; }
        public AlbumDTO Album { get; set; }
    }
}
