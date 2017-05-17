using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStarterBackend.Models
{
    public class AlbumDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoverFile { get; set; }

        public AuthorDTO Author { get; set; }
    }
}
