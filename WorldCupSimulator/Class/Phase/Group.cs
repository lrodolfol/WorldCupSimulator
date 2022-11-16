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
        private string _phaseGroup;

        public Group()
        {
            TeamList = new List<Team>();
        }
        public void start(string phaseGroup)
        {
            _phaseGroup = phaseGroup;   
            if(TeamList.Count < 4)
            {
                throw new Exception("Oops! The group don't have necessary teams.");
            }

            Console.WriteLine($"The {phaseGroup} started! Wait the results");

            for (int i = 0; i < TeamList.Count; i++)
            {
                for (int x = (i+1); x < TeamList.Count; x++)
                {
                    Match match = new Match(TeamList[i], TeamList[x]);
                    match.Play();
                }
            }
        }

        private List<Team> Classification()
        {
            List<Team> classificationTeam = (from t in TeamList
                                     orderby t.victories descending, t.goals descending
                                     select t).ToList();

            return classificationTeam;
        }

        public List<Team> FinalistsTeams()
        {
            Console.WriteLine($"Classification of {_phaseGroup}:");

            var classificationTeam = this.Classification();
            List<Team> finalists = new List<Team>();
            for(int i = 0; i <= classificationTeam.Count - 1; i++)
            {
                if (i <= 1) 
                {
                    finalists.Add(classificationTeam[i]);
                }
                else
                {
                    classificationTeam[i].status = Enum.Status.Eliminated;
                }

                int st = i <= 2 ? i+1 : 4;
                Console.WriteLine($"{st}st: {classificationTeam[i].Name} - {classificationTeam[i].status}");
            }

            Console.WriteLine("Press any to Continue");
            Console.ReadKey();
            Console.Clear();
            return finalists;  
        }
    }
    
}
