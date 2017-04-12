using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStarterBackend.Models
{
    public class Track
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
