using WorldCupSimulator.Interface;

namespace WorldCupSimulator.Class.Matches
{
    public class RoundFinal : IPhase
    {
        public List<Team> TeamList { get; set; }

        public RoundFinal()
        {
            TeamList = new List<Team>();    
        }

        public void start(string phaseGroup)
        {
            if (TeamList.Count != 2)
            {
                throw new Exception("Oops! The group don't have necessary teams.");
            }

            foreach (Team team in TeamList)
            {
                team.victories = 0;
                team.goals = 0;
            }

            Match match = new Match(TeamList[0], TeamList[1]);

            match.Play();
        }

        public List<Team> FinalistsTeams()
        {
            List<Team> finalists =
                        (from t in TeamList
                         orderby t.victories descending
                         select t
                        ).ToList();

            for(int i = 0; i <= finalists.Count - 1; i ++)
            {
                if(i > 0)
                {
                    finalists[i].status = Enum.Status.Eliminated;
                    finalists.RemoveAt(i);
                }
            }

            Console.WriteLine("Press any to Continue");
            Console.ReadKey();
            Console.Clear();

            return finalists;
        }
    }
}
