﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupSimulator.Interface;

namespace WorldCupSimulator.Class
{
    public class RoundFinal : IPhase
    {
        public List<Team> TeamList { get; set; }

        public RoundFinal()
        {
            TeamList = new List<Team>();    
        }

        public void start()
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
            var finalists =
                        (from t in TeamList
                         orderby t.victories descending
                         select t
                        ).Take(1)
                        .ToList();

            return finalists;
        }
    }
}
