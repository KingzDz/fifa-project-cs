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
        public int CurrentBet { get; set; }

        public Bettor(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        public void Payout(bool betWon)
        {
            int cashEarned;

            if(betWon == true)
            {
                cashEarned = CurrentBet *= 2;
            }
            else
            {
                cashEarned = -CurrentBet;
            }

            Cash += cashEarned;
        }
    }
}
