using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace BibliotekaTEST
{
    public class Film
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("episode_id")]
        public string Episode { get; set; }

        [JsonProperty("opening_crawl")]
        public string Opening { get; set; }

        [JsonProperty("director")]
        public string Director { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("characters")]
        public List <String> Characters { get; set; }

    }

    public class Character
    {
        public String Name { get; set; }
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}
