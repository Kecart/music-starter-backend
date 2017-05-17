using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStarterBackend
{
    public static class Database
    {
        public static DataModelContainer Container { get; } = new DataModelContainer();

        public static Track ConvertTrack(Track other)
        {
            return new Track
            {
                Id = other.Id,
                Title = other.Title,
                Duration = other.Duration,
                DateTime = other.DateTime,
                Rating = other.Rating,
                File = other.File,

                Author = ConvertAuthor(other.Author),
                Album = other.Album == null ? null : ConvertAlbum(other.Album)
            };
        }

        public static Author ConvertAuthor(Author other)
        {
            return new Author
            {
                Id = other.Id,
                Name = other.Name
            };
        }

        public static Album ConvertAlbum(Album other)
        {
            return new Album
            {
                Id = other.Id,
                Name = other.Name,
                CoverFile = other.CoverFile,

                Author = ConvertAuthor(other.Author)
            };
        }
    }
}
