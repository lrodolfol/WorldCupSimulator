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
        public static Team? TeamWinner { get;set; }

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

            Console.WriteLine($"{TeamA.Name} Vs {TeamB.Name}");

            TeamWinner = goalsTeamA > goalsTeamB ? this.TeamA : this.TeamB;

            // there may be a tie
            Random rand = new Random();
            TeamWinner = (rand.Next(11)) == 0 ? this.TeamA : this.TeamB;

            if (goalsTeamA > goalsTeamB)
            {
                this.TeamA.victories++;
                this.TeamB.defeats++;
            }
            else if (goalsTeamB > goalsTeamA)
            {
                this.TeamB.victories++;
                this.TeamA.defeats++;
            }

            Console.WriteLine($"\t Winner: {TeamWinner.Name} ");
            Thread.Sleep(2000);
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
