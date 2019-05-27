using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaProject
{
    public class Bettor
    {
        public string Name { get; set; }
        public int Cash{ get; set; }

        public List<Matches> MatchesBetOn { get; set; }

        public class Matches
        {
            public string MatchName { get; set; }
            public int CurrentBet { get; set; }
            public string TeamBetOn { get; set; }
            public string Score { get; set; }
            public string ListMessage { get; set; }

            public Matches(string name, int cb, string tbo, string score, string lm)
            {
                MatchName = name;
                CurrentBet = cb;
                TeamBetOn = tbo;
                Score = score;
                ListMessage = lm;
            }

            /// <summary>
            /// Resets the values of this class.
            /// </summary>
            public void ResetValues()
            {
                MatchName = null;
                CurrentBet = 0;
                TeamBetOn = null;
                Score = null;
                ListMessage = null;
            }
        }

        public Bettor(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        public void SetBet(string name, int cb, string tbo, string score, string lm)
        {
            Matches NewMatch = new Matches(name, cb, tbo, score, lm);
            
            MatchesBetOn.Add(NewMatch);
        }

        public void Payout(bool betWon)
        {

        }
    }
}
