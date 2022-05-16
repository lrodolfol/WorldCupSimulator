using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupSimulator.Interface
{
    public interface IPhase
    {
        public List<Team> TeamList { get; set; }
        void start();
        public List<Team> FinalistsTeams();
    }
}
