using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using MusicStarterBackend.Models;

namespace MusicStarterBackend.Controllers
{
    /// <summary>
    /// TracksController is handling REST requests made by client.
    /// </summary>
    public class TracksController : ApiController
    {
        /// <summary>
        /// Contains collection of authors.
        /// </summary>
        private List<Author> authors = new List<Author>();
        /// <summary>
        /// Contains collection of tracks.
        /// </summary>
        private List<Track> tracks = new List<Track>();

        /// <summary>
        /// Is used to insert sample data to collection: <see cref="authors"/> and <see cref="tracks"/>.
        /// This method is used for prototyping.
        /// </summary>
        private void Seed()
        {
            authors.Add(new Author { Id = 1, Name = "Author1" });
            authors.Add(new Author { Id = 2, Name = "Author2" });

            tracks.Add(new Track {
                Id = 1, Title = "Track1", Duration = new TimeSpan(0, 1, 10),
                DateTime = new DateTime(2017, 04, 11, 12, 0, 0), Rating = 3.5F, Author = authors[0]
            });
            tracks.Add(new Track {
                Id = 2, Title = "Track2", Duration = new TimeSpan(0, 4, 03),
                DateTime = new DateTime(2017, 04, 12, 18, 30, 45), Rating = 4.5F, Author = authors[0]
            });
            tracks.Add(new Track {
                Id = 3, Title = "Track3", Duration = new TimeSpan(0, 2, 49),
                DateTime = new DateTime(2017, 04, 13, 03, 06, 14), Rating = 4.0F, Author = authors[1]
            });
        }

        /// <summary>
        /// Default and only constructor.
        /// Calls <see cref="Seed()"/> method.
        /// </summary>
        public TracksController()
        {
            Seed();
        }

        // GET api/tracks 
        /// <summary>
        /// Is invoked when server receives GET api/tracks request.
        /// </summary>
        /// <returns>Collection of tracks</returns>
        public IEnumerable<Track> Get()
        {
            return tracks;
        }

        // GET api/tracks/5 
        /// <summary>
        /// Is invoked when server receives GET api/tracks/{id} request.
        /// </summary>
        /// <param name="id">Id parameter from GET request</param>
        /// <returns>If there is exactly one track with requested id, then that track. Otherwise, null.</returns>
        public Track Get(int id)
        {
            var requested_tracks = tracks.Where(track => track.Id == id);
            if (requested_tracks.Count() != 1) return null;
            return requested_tracks.First();
        }
    }
}
