using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupSimulator.Interface
{
    public interface IMatch
    {
        public void ScoredGoal();
        public void Play();
    }
}
