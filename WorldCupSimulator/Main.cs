using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupSimulator.Class;
using WorldCupSimulator.Interface;

namespace WorldCupSimulator
{

    public class Main
    {
        List<Team> teamsAList = new List<Team>();
        List<Team> teamsBList = new List<Team>();
        List<Team> teamsCList = new List<Team>();
        List<Team> teamsDList = new List<Team>();
        List<Team> teamsEList = new List<Team>();
        List<Team> teamsFList = new List<Team>();
        List<Team> teamsGList = new List<Team>();
        List<Team> teamsHList = new List<Team>();

        public List<Team> teamsFinalistsGroupA { get; private set; }
        public List<Team> teamsFinalistsGroupB { get; private set; }
        public List<Team> teamsFinalistsGroupC { get; private set; }
        public List<Team> teamsFinalistsGroupD { get; private set; }
        public List<Team> teamsFinalistsGroupE { get; private set; }
        public List<Team> teamsFinalistsGroupF { get; private set; }
        public List<Team> teamsFinalistsGroupG { get; private set; }
        public List<Team> teamsFinalistsGroupH { get; private set; }

        public List<Team> teamsFinalistsRoundSexteenA { get; private set; }
        public List<Team> teamsFinalistsRoundSexteenB { get; private set; }
        public List<Team> teamsFinalistsRoundSexteenC { get; private set; }
        public List<Team> teamsFinalistsRoundSexteenD { get; private set; }
        public List<Team> teamsFinalistsRoundSexteenE { get; private set; }
        public List<Team> teamsFinalistsRoundSexteenF { get; private set; }
        public List<Team> teamsFinalistsRoundSexteenG { get; private set; }
        public List<Team> teamsFinalistsRoundSexteenH { get; private set; }

        public List<Team> teamsFinalistsRoundEightA { get; private set; }
        public List<Team> teamsFinalistsRoundEightB { get; private set; }
        public List<Team> teamsFinalistsRoundEightC { get; private set; }
        public List<Team> teamsFinalistsRoundEightD { get; private set; }

        public List<Team> teamsFinalistsSemiFinalA { get; private set; }
        public List<Team> teamsFinalistsSemiFinalB { get; private set; }

        public List<Team> teamsFinalistsFinal = new List<Team>();

        public List<Team> TeamWinner = new List<Team>();

        public void Start(List<Team> teams)
        {
            if (teams == null || teams.Count == 0)
            {
                throw new ArgumentNullException(
                    "there are no teams, or the number of times is wrong. Please check the file"
                    );
            }

            SwitchTeams(teams);
        }

        public void SwitchTeams(List<Team> teams)
        {
            foreach(var team in teams)
            {
                switch (team.Group)
                {
                    case "A":
                        teamsAList.Add(team); 
                        break;
                    case "B":
                        teamsBList.Add(team);
                        break;
                    case "C":
                        teamsCList.Add(team);
                        break;
                    case "D":
                        teamsDList.Add(team);
                        break;
                    case "E":
                        teamsEList.Add(team);
                        break;
                    case "F":
                        teamsFList.Add(team);
                        break;
                    case "G":
                        teamsGList.Add(team);
                        break;
                    case "H":
                        teamsHList.Add(team);
                        break;
                }
            }
        }

        public void FillGroups()
        {
            /*==START GROUP A==*/
            IPhase groupA = new Group();
            groupA.TeamList = teamsAList;
            groupA.start();
            this.teamsFinalistsGroupA = groupA.FinalistsTeams();

            /*==START GROUP B==*/
            IPhase groupB = new Group();
            groupB.TeamList = teamsBList;
            groupB.start();
            this.teamsFinalistsGroupB = groupB.FinalistsTeams();

            /*==START GROUP C==*/
            IPhase groupC = new Group();
            groupC.TeamList = teamsCList;
            groupC.start();
            this.teamsFinalistsGroupC = groupC.FinalistsTeams();

            /*==START GROUP D==*/
            IPhase groupD = new Group();
            groupD.TeamList = teamsDList;
            groupD.start();
            this.teamsFinalistsGroupD = groupD.FinalistsTeams();

            /*==START GROUP E==*/
            IPhase groupE = new Group();
            groupE.TeamList = teamsEList;
            groupE.start();
            this.teamsFinalistsGroupE = groupE.FinalistsTeams();

            /*==START GROUP F==*/
            IPhase groupF = new Group();
            groupF.TeamList = teamsFList;
            groupF.start();
            this.teamsFinalistsGroupF = groupF.FinalistsTeams();

            /*==START GROUP G==*/
            IPhase groupG = new Group();
            groupG.TeamList = teamsGList;
            groupG.start();
            this.teamsFinalistsGroupG = groupG.FinalistsTeams();

            /*==START GROUP H==*/
            IPhase groupH = new Group();
            groupH.TeamList = teamsHList;
            groupH.start();
            this.teamsFinalistsGroupH = groupH.FinalistsTeams();

            this.ShowGroupsFinalists();
        }
        public void FillRoundSexteen()
        {
            IPhase RoundSexteenA = new RoundFinal();
            RoundSexteenA.TeamList.Add(teamsFinalistsGroupA[0]);
            RoundSexteenA.TeamList.Add(teamsFinalistsGroupB[1]);
            RoundSexteenA.start();
            teamsFinalistsRoundSexteenA = RoundSexteenA.FinalistsTeams();

            IPhase RoundSexteenB = new RoundFinal();
            RoundSexteenB.TeamList.Add(teamsFinalistsGroupB[0]);
            RoundSexteenB.TeamList.Add(teamsFinalistsGroupA[1]);
            RoundSexteenB.start();
            teamsFinalistsRoundSexteenB = RoundSexteenB.FinalistsTeams();

            IPhase RoundSexteenC = new RoundFinal();
            RoundSexteenC.TeamList.Add(teamsFinalistsGroupC[0]);
            RoundSexteenC.TeamList.Add(teamsFinalistsGroupD[1]);
            RoundSexteenC.start();
            teamsFinalistsRoundSexteenC = RoundSexteenC.FinalistsTeams();

            IPhase RoundSexteenD = new RoundFinal();
            RoundSexteenD.TeamList.Add(teamsFinalistsGroupD[0]);
            RoundSexteenD.TeamList.Add(teamsFinalistsGroupC[1]);
            RoundSexteenD.start();
            teamsFinalistsRoundSexteenD = RoundSexteenD.FinalistsTeams();

            IPhase RoundSexteenE = new RoundFinal();
            RoundSexteenE.TeamList.Add(teamsFinalistsGroupE[0]);
            RoundSexteenE.TeamList.Add(teamsFinalistsGroupF[1]);
            RoundSexteenE.start();
            teamsFinalistsRoundSexteenE = RoundSexteenE.FinalistsTeams();

            IPhase RoundSexteenF = new RoundFinal();
            RoundSexteenF.TeamList.Add(teamsFinalistsGroupF[0]);
            RoundSexteenF.TeamList.Add(teamsFinalistsGroupE[1]);
            RoundSexteenF.start();
            teamsFinalistsRoundSexteenF = RoundSexteenF.FinalistsTeams();

            IPhase RoundSexteenG = new RoundFinal();
            RoundSexteenG.TeamList.Add(teamsFinalistsGroupG[0]);
            RoundSexteenG.TeamList.Add(teamsFinalistsGroupH[1]);
            RoundSexteenG.start();
            teamsFinalistsRoundSexteenG = RoundSexteenG.FinalistsTeams();

            IPhase RoundSexteenH = new RoundFinal();
            RoundSexteenH.TeamList.Add(teamsFinalistsGroupH[0]);
            RoundSexteenH.TeamList.Add(teamsFinalistsGroupG[1]);
            RoundSexteenH.start();
            teamsFinalistsRoundSexteenH = RoundSexteenH.FinalistsTeams();

            this.ShowRoundSexteenFinalists();
        }
        public void FillRoundEight()
        {
            IPhase RoundEightA = new RoundFinal();
            RoundEightA.TeamList.Add(teamsFinalistsRoundSexteenA[0]);
            RoundEightA.TeamList.Add(teamsFinalistsRoundSexteenC[0]);
            RoundEightA.start();
            teamsFinalistsRoundEightA = RoundEightA.FinalistsTeams();

            IPhase RoundEightB = new RoundFinal();
            RoundEightB.TeamList.Add(teamsFinalistsRoundSexteenB[0]);
            RoundEightB.TeamList.Add(teamsFinalistsRoundSexteenD[0]);
            RoundEightB.start();
            teamsFinalistsRoundEightB = RoundEightB.FinalistsTeams();

            IPhase RoundEightC = new RoundFinal();
            RoundEightC.TeamList.Add(teamsFinalistsRoundSexteenE[0]);
            RoundEightC.TeamList.Add(teamsFinalistsRoundSexteenG[0]);
            RoundEightC.start();
            teamsFinalistsRoundEightC = RoundEightC.FinalistsTeams();

            IPhase RoundEightD = new RoundFinal();
            RoundEightD.TeamList.Add(teamsFinalistsRoundSexteenF[0]);
            RoundEightD.TeamList.Add(teamsFinalistsRoundSexteenH[0]);
            RoundEightD.start();
            teamsFinalistsRoundEightD = RoundEightD.FinalistsTeams();

            this.ShowRoundEightFinalists();
        }
        public void FillSemiFinal()
        {
            IPhase SemiFinalA = new RoundFinal();
            SemiFinalA.TeamList.Add(teamsFinalistsRoundEightA[0]);
            SemiFinalA.TeamList.Add(teamsFinalistsRoundEightC[0]);
            SemiFinalA.start();
            teamsFinalistsSemiFinalA = SemiFinalA.FinalistsTeams();

            IPhase SemiFinalB = new RoundFinal();
            SemiFinalB.TeamList.Add(teamsFinalistsRoundEightB[0]);
            SemiFinalB.TeamList.Add(teamsFinalistsRoundEightD[0]);
            SemiFinalB.start();
            teamsFinalistsSemiFinalB = SemiFinalB.FinalistsTeams();

            this.ShowSemiFinalFinalists();  
        }       
        public void FillFinal()
        {
            IPhase Final = new RoundFinal();
            Final.TeamList.Add(teamsFinalistsSemiFinalA[0]);
            Final.TeamList.Add(teamsFinalistsSemiFinalB[0]);
            Final.start();
            TeamWinner = Final.FinalistsTeams();

            this.ShowWinner();
        }



        private void ShowGroupsFinalists()
        {
            Console.WriteLine("We are the Finalist for round Sexteeen phase: ");
            Console.WriteLine($"{teamsFinalistsGroupA[0].Name} Vs {teamsFinalistsGroupB[1].Name}");
            Console.WriteLine($"{teamsFinalistsGroupB[0].Name} Vs {teamsFinalistsGroupA[1].Name}");
            Console.WriteLine($"{teamsFinalistsGroupC[0].Name} Vs {teamsFinalistsGroupD[1].Name}");
            Console.WriteLine($"{teamsFinalistsGroupD[0].Name} Vs {teamsFinalistsGroupC[1].Name}");
            Console.WriteLine($"{teamsFinalistsGroupE[0].Name} Vs {teamsFinalistsGroupF[1].Name}");
            Console.WriteLine($"{teamsFinalistsGroupF[0].Name} Vs {teamsFinalistsGroupE[1].Name}");
            Console.WriteLine($"{teamsFinalistsGroupG[0].Name} Vs {teamsFinalistsGroupH[1].Name}");
            Console.WriteLine($"{teamsFinalistsGroupH[0].Name} Vs {teamsFinalistsGroupG[1].Name}");
        }
        private void ShowRoundSexteenFinalists()
        {
            Console.WriteLine("We are the Finalist for round eight phase: ");
            Console.WriteLine($"{teamsFinalistsRoundSexteenA[0].Name} Vs {teamsFinalistsRoundSexteenC[0].Name}");
            Console.WriteLine($"{teamsFinalistsRoundSexteenB[0].Name} Vs {teamsFinalistsRoundSexteenD[0].Name}");
            Console.WriteLine($"{teamsFinalistsRoundSexteenE[0].Name} Vs {teamsFinalistsRoundSexteenG[0].Name}");
            Console.WriteLine($"{teamsFinalistsRoundSexteenF[0].Name} Vs {teamsFinalistsRoundSexteenH[0].Name}");
        }
        private void ShowRoundEightFinalists()
        {
            Console.WriteLine("We are the Finalist for semi final phase: ");
            Console.WriteLine($"{teamsFinalistsRoundEightA[0].Name} Vs {teamsFinalistsRoundEightC[0].Name}");
            Console.WriteLine($"{teamsFinalistsRoundEightB[0].Name} Vs {teamsFinalistsRoundEightD[0].Name}");
        }
        private void ShowSemiFinalFinalists()
        {
            Console.WriteLine("We are the Final: ");
            Console.WriteLine($"{teamsFinalistsSemiFinalA[0].Name} Vs {teamsFinalistsSemiFinalB[0].Name}");
        }
        private void ShowWinner()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("=====And the Winner is...=====");
            Console.WriteLine($"======{TeamWinner[0].Name}!!!======");
            Console.WriteLine("=======Congratulations!=======");
        }


        
    }
}
