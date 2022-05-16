using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupSimulator.Interface;

namespace WorldCupSimulator.Class
{
    public class Group : IPhase
    {
        public List<Team> TeamList {get;set;}
        static List<Match> MatchList;

        public Group()
        {
            TeamList = new List<Team>();
        }
        public void start()
        {
            
            if(TeamList.Count < 4)
            {
                throw new Exception("Oops! The group don't have necessary teams.");
            }

            for (int i = 0; i < TeamList.Count; i++)
            {
                for (int x = (i+1); x < TeamList.Count; x++)
                {
                    Match match = new Match(TeamList[i], TeamList[x]);
                    MatchList.Add(match);   
                    match.Play();
                }
            }
        }

        public List<Team> FinalistsTeams()
        {
            var finalists =  
                        (from t in TeamList
                            orderby t.victories descending
                            select t
                        ).Take(2)
                        .ToList();

            return finalists;   
        }
    }
    
}
