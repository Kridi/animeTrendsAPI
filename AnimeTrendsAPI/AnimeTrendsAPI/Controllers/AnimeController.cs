
using System;
using System.Collections.Generic;
using System.Web.Http;
using AnimeTrendsAPI.Data;
using AnimeTrendsAPI.Models;

namespace AnimeTrendsAPI.Controllers
{
    public class AnimeController : ApiController
    {
        // GET api/values 
        public List<Anime> Get()
        {
            return AnimeData.AnimeList;
        }
        public void Post([FromBody] Anime anime)
        {
            AnimeData.AnimeList.Add(anime);
        }
    }
}