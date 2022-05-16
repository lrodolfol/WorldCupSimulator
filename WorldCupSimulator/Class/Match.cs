using System;
using System.Linq;
using System.Text;
using WorldCupSimulator.Interface;

namespace WorldCupSimulator.Class
{
    public class Match : IMatch
    {
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        public static Team TeamWinner { get;set; }

        private int goalsTeamA = 0;
        private int goalsTeamB = 0;
        public Match(Team teamA, Team teamB)
        {
            this.TeamA = teamA;
            this.TeamB = teamB;
        }

        public void Play()
        {
            ScoredGoal();

            if (goalsTeamA > goalsTeamB)
            {
                this.TeamA.victories++;
                TeamWinner = this.TeamA;
            }
            else if (goalsTeamB > goalsTeamA)
            {
                this.TeamB.victories++;
                TeamWinner = this.TeamB;
            }
            // there may be a tie
        }

        public void ScoredGoal()
        {
           while (goalsTeamA <= (TeamA.Force))
           {
                Random rand = new Random(); 
                goalsTeamA += rand.Next(300);
            }
            this.TeamA.goals += goalsTeamA;    

            while (goalsTeamB <= (TeamB.Force))
            {
                Random rand = new Random();
                goalsTeamB  += rand.Next(300);
            }
            this.TeamB.goals += goalsTeamB;
        }

    }
}
