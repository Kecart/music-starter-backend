using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using MusicStarterBackend.Models;

namespace MusicStarterBackend.Controllers
{
    public class TracksController : ApiController
    {
        private Track[] tracks = new Track[]
        {
            new Track { Author = "Author1", Title = "Title1", Duration = new TimeSpan(0, 2, 10) },
            new Track { Author = "Author2", Title = "Title2", Duration = new TimeSpan(0, 0, 52) }
        };

        // GET api/tracks 
        public IEnumerable<Track> Get()
        {
            return tracks;
        }

        //// GET api/values/5 
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values 
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5 
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5 
        //public void Delete(int id)
        //{
        //}
    }
}
