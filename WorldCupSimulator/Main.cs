using System.Text;
using WorldCupSimulator.Class.Matches;
using WorldCupSimulator.Class.Phase;
using WorldCupSimulator.Exceptions;
using WorldCupSimulator.Interface;

namespace WorldCupSimulator
{
    public class Main
    {
        GroupPhaseTeams groupPhaseTeams = new();

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
            if (teams == null || teams.Count != 32)
                throw new CupException("OOps, there are no teams, or the number of times is wrong. Please check the file");
            
            SwitchTeams(teams);
        }

        public void SwitchTeams(List<Team> teams)
        {
            foreach(var team in teams)
            {
                switch (team.Group)
                {
                    case "A":
                        groupPhaseTeams.AddTeamGroupA(team); 
                        break;
                    case "B":
                        groupPhaseTeams.AddTeamGroupB(team);
                        break;
                    case "C":
                        groupPhaseTeams.AddTeamGroupC(team);
                        break;
                    case "D":
                        groupPhaseTeams.AddTeamGroupD(team);
                        break;
                    case "E":
                        groupPhaseTeams.AddTeamGroupE(team);
                        break;
                    case "F":
                        groupPhaseTeams.AddTeamGroupF(team);
                        break;
                    case "G":
                        groupPhaseTeams.AddTeamGroupG(team);
                        break;
                    case "H":
                        groupPhaseTeams.AddTeamGroupH(team);
                        break;
                    default:
                        StringBuilder strDefault = new StringBuilder("Oops there are teams without group: ");
                        strDefault.Append(team.Name);
                        strDefault.Append(". Please, Check the File");

                        throw new CupException(strDefault.ToString());
                }
            }
        }

        public void FillGroups()
        {
            /*==START GROUP A==*/
            IPhase groupA = new Group();
            groupA.TeamList = groupPhaseTeams.GroupA.ToList();
            groupA.start(nameof(groupA));
            groupPhaseTeams.AddGroupAFinalists(groupA.FinalistsTeams());

            /*==START GROUP B==*/
            IPhase groupB = new Group();
            groupB.TeamList = groupPhaseTeams.GroupB.ToList();
            groupB.start(nameof(groupB));
            groupPhaseTeams.AddGroupBFinalists(groupB.FinalistsTeams());

            /*==START GROUP C==*/
            IPhase groupC = new Group();
            groupC.TeamList = groupPhaseTeams.GroupC.ToList(); ;
            groupC.start(nameof(groupC));
            groupPhaseTeams.AddGroupCFinalists(groupC.FinalistsTeams());

            /*==START GROUP D==*/
            IPhase groupD = new Group();
            groupD.TeamList = groupPhaseTeams.GroupD.ToList(); ;
            groupD.start(nameof(groupD));
            groupPhaseTeams.AddGroupDFinalists(groupD.FinalistsTeams());

            /*==START GROUP E==*/
            IPhase groupE = new Group();
            groupE.TeamList = groupPhaseTeams.GroupE.ToList(); ;
            groupE.start(nameof(groupE));
            groupPhaseTeams.AddGroupEFinalists(groupE.FinalistsTeams());

            /*==START GROUP F==*/
            IPhase groupF = new Group();
            groupF.TeamList = groupPhaseTeams.GroupF.ToList();
            groupF.start(nameof(groupF));
            groupPhaseTeams.AddGroupFFinalists(groupF.FinalistsTeams());

            /*==START GROUP G==*/
            IPhase groupG = new Group();
            groupG.TeamList = groupPhaseTeams.GroupG.ToList();
            groupG.start(nameof(groupG));
            groupPhaseTeams.AddGroupGFinalists(groupG.FinalistsTeams());

            /*==START GROUP H==*/
            IPhase groupH = new Group();
            groupH.TeamList = groupPhaseTeams.GroupH.ToList();
            groupH.start(nameof(groupH));
            groupPhaseTeams.AddGroupGFinalists(groupH.FinalistsTeams());

            this.ShowGroupsFinalists();
        }
        public void FillRoundSexteen()
        {
            IPhase RoundSexteenA = new RoundFinal();
            RoundSexteenA.TeamList.Add(groupPhaseTeams.FinalistGroupA.ToList()[0]);
            RoundSexteenA.TeamList.Add(groupPhaseTeams.FinalistGroupB.ToList()[1]);
            RoundSexteenA.start(nameof(RoundSexteenA));
            teamsFinalistsRoundSexteenA = RoundSexteenA.FinalistsTeams();

            IPhase RoundSexteenB = new RoundFinal();
            RoundSexteenB.TeamList.Add(groupPhaseTeams.FinalistGroupB.ToList()[0]);
            RoundSexteenB.TeamList.Add(groupPhaseTeams.FinalistGroupA.ToList()[1]);
            RoundSexteenB.start(nameof(RoundSexteenB));
            teamsFinalistsRoundSexteenB = RoundSexteenB.FinalistsTeams();

            IPhase RoundSexteenC = new RoundFinal();
            RoundSexteenC.TeamList.Add(groupPhaseTeams.FinalistGroupC.ToList()[0]);
            RoundSexteenC.TeamList.Add(groupPhaseTeams.FinalistGroupD.ToList()[1]);
            RoundSexteenC.start(nameof(RoundSexteenC));
            teamsFinalistsRoundSexteenC = RoundSexteenC.FinalistsTeams();

            IPhase RoundSexteenD = new RoundFinal();
            RoundSexteenD.TeamList.Add(groupPhaseTeams.FinalistGroupD.ToList()[0]);
            RoundSexteenD.TeamList.Add(groupPhaseTeams.FinalistGroupC.ToList()[1]);
            RoundSexteenD.start(nameof(RoundSexteenD));
            teamsFinalistsRoundSexteenD = RoundSexteenD.FinalistsTeams();

            IPhase RoundSexteenE = new RoundFinal();
            RoundSexteenE.TeamList.Add(groupPhaseTeams.FinalistGroupE.ToList()[0]);
            RoundSexteenE.TeamList.Add(groupPhaseTeams.FinalistGroupF.ToList()[1]);
            RoundSexteenE.start(nameof(RoundSexteenE));
            teamsFinalistsRoundSexteenE = RoundSexteenE.FinalistsTeams();

            IPhase RoundSexteenF = new RoundFinal();
            RoundSexteenF.TeamList.Add(groupPhaseTeams.FinalistGroupF.ToList()[0]);
            RoundSexteenF.TeamList.Add(groupPhaseTeams.FinalistGroupE.ToList()[1]);
            RoundSexteenF.start(nameof(RoundSexteenF));
            teamsFinalistsRoundSexteenF = RoundSexteenF.FinalistsTeams();

            IPhase RoundSexteenG = new RoundFinal();
            RoundSexteenG.TeamList.Add(groupPhaseTeams.FinalistGroupG.ToList()[0]);
            RoundSexteenG.TeamList.Add(groupPhaseTeams.FinalistGroupH.ToList()[1]);
            RoundSexteenG.start(nameof(RoundSexteenF));
            teamsFinalistsRoundSexteenG = RoundSexteenG.FinalistsTeams();

            IPhase RoundSexteenH = new RoundFinal();
            RoundSexteenH.TeamList.Add(groupPhaseTeams.FinalistGroupH.ToList()[0]);
            RoundSexteenH.TeamList.Add(groupPhaseTeams.FinalistGroupG.ToList()[1]);
            RoundSexteenH.start(nameof(RoundSexteenG));
            teamsFinalistsRoundSexteenH = RoundSexteenH.FinalistsTeams();

            this.ShowRoundSexteenFinalists();
        }
        public void FillRoundEight()
        {
            IPhase RoundEightA = new RoundFinal();
            RoundEightA.TeamList.Add(teamsFinalistsRoundSexteenA[0]);
            RoundEightA.TeamList.Add(teamsFinalistsRoundSexteenC[0]);
            RoundEightA.start(nameof(RoundEightA));
            teamsFinalistsRoundEightA = RoundEightA.FinalistsTeams();

            IPhase RoundEightB = new RoundFinal();
            RoundEightB.TeamList.Add(teamsFinalistsRoundSexteenB[0]);
            RoundEightB.TeamList.Add(teamsFinalistsRoundSexteenD[0]);
            RoundEightB.start(nameof(RoundEightB));
            teamsFinalistsRoundEightB = RoundEightB.FinalistsTeams();

            IPhase RoundEightC = new RoundFinal();
            RoundEightC.TeamList.Add(teamsFinalistsRoundSexteenE[0]);
            RoundEightC.TeamList.Add(teamsFinalistsRoundSexteenG[0]);
            RoundEightC.start(nameof(RoundEightC));
            teamsFinalistsRoundEightC = RoundEightC.FinalistsTeams();

            IPhase RoundEightD = new RoundFinal();
            RoundEightD.TeamList.Add(teamsFinalistsRoundSexteenF[0]);
            RoundEightD.TeamList.Add(teamsFinalistsRoundSexteenH[0]);
            RoundEightD.start(nameof(RoundEightD));
            teamsFinalistsRoundEightD = RoundEightD.FinalistsTeams();

            this.ShowRoundEightFinalists();
        }
        public void FillSemiFinal()
        {
            IPhase SemiFinalA = new RoundFinal();
            SemiFinalA.TeamList.Add(teamsFinalistsRoundEightA[0]);
            SemiFinalA.TeamList.Add(teamsFinalistsRoundEightC[0]);
            SemiFinalA.start(nameof(SemiFinalA));
            teamsFinalistsSemiFinalA = SemiFinalA.FinalistsTeams();

            IPhase SemiFinalB = new RoundFinal();
            SemiFinalB.TeamList.Add(teamsFinalistsRoundEightB[0]);
            SemiFinalB.TeamList.Add(teamsFinalistsRoundEightD[0]);
            SemiFinalB.start(nameof(SemiFinalB));
            teamsFinalistsSemiFinalB = SemiFinalB.FinalistsTeams();

            this.ShowSemiFinalFinalists();  
        }       
        public void FillFinal()
        {
            IPhase Final = new RoundFinal();
            Final.TeamList.Add(teamsFinalistsSemiFinalA[0]);
            Final.TeamList.Add(teamsFinalistsSemiFinalB[0]);
            Final.start(nameof(Final));
            TeamWinner = Final.FinalistsTeams();

            this.ShowWinner();
        }

        private void ShowGroupsFinalists()
        {
            Console.WriteLine("We are the Finalist for round Sexteeen phase: ");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupA.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupB.ToList()[1].Name}");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupB.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupA.ToList()[1].Name}");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupC.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupD.ToList()[1].Name}");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupD.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupC.ToList()[1].Name}");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupE.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupF.ToList()[1].Name}");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupF.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupE.ToList()[1].Name}");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupG.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupH.ToList()[1].Name}");
            Console.WriteLine($@"{groupPhaseTeams.FinalistGroupH.ToList()[0].Name} Vs
                {groupPhaseTeams.FinalistGroupG.ToList()[1].Name}");
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
