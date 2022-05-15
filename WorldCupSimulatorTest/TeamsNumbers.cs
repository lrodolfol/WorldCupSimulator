using System;
using System.Collections.Generic;
using System.IO;
using WorldCupSimulator;
using WorldCupSimulator.Class;
using WorldCupSimulator.Interface;
using Xunit;

namespace WorldCupSimulatorTest
{
    public class TeamsNumbers
    {
        [Fact]
        public void mustHave32TeamsGroupPhase()
        {
            List<Team> team = new List<Team>();
            team.Add(new Team("Brazil", "A", 1800));
            team.Add(new Team("Argentina", "A", 1800));

            Main main = new Main();

            Assert.Throws<ArgumentNullException>(
                () => main.Start(team)
                );
        }

     
        


    }
}
