using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FifaProject
{
    public class FetchTeam
    {
        public class Record
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("teamname")]
            public string TeamName { get; set; }

            [JsonProperty("players")]
            public string Players { get; set; }

            [JsonProperty("leader")]
            public string Leader { get; set; }
        }

        public class RootObject
        {
            [JsonProperty("records")]
            //public Dictionary<int, Records> Records { get; set; }
            public List<Record> records { get; set; }
        }
    }
}
