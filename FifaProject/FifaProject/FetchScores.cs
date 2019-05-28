using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FifaProject
{
    public class FetchScores
    {
        public class Record
        {
            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("firstteam")]
            public string firstteam { get; set; }

            [JsonProperty("firstscore")]
            public int firstscore { get; set; }

            [JsonProperty("secondteam")]
            public string secondteam { get; set; }

            [JsonProperty("secondscore")]
            public int secondscore { get; set; }

            
        }

        public class RootObject
        {
            [JsonProperty("result")]
            public List<Record> Records { get; set; }
        }

    }
}

