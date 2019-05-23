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
        [JsonProperty("id")]
        public List<int> Id { get; set; }

        [JsonProperty("firstteam")]
        public List<string> FirstTeam { get; set; }

        [JsonProperty("firstscore")]
        public List<int> FirstScore { get; set; }

        [JsonProperty("secondteam")]
        public List<string> SecondTeam { get; set; }

        [JsonProperty("secondscore")]
        public List<int> SecondScore { get; set; }

    }
}

