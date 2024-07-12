using System.Text;
using WorldCupSimulator.Class.Matches;
using WorldCupSimulator.Class.Phase;
using WorldCupSimulator.Exceptions;
using WorldCupSimulator.Interface;

namespace WorldCupSimulator
{
    public class Main
    {
        private GroupPhaseTeams groupPhaseTeams = new();
        private SixteenGroup SixteenGroup = new();
        private EightGroup EightGroup = new();
        private SemiFinalGroup SemiFinalGroup = new();
        
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
            groupPhaseTeams.AddGroupHFinalists(groupH.FinalistsTeams());

            this.ShowGroupsFinalists();
        }
        public void FillRoundSixteen()
        {
            IPhase RoundSixteenA = new RoundFinal();
            RoundSixteenA.TeamList.Add(groupPhaseTeams.FinalistGroupA.ToList()[0]);
            RoundSixteenA.TeamList.Add(groupPhaseTeams.FinalistGroupB.ToList()[1]);
            RoundSixteenA.start(nameof(RoundSixteenA));
            SixteenGroup.AddFinalistsGroupA(RoundSixteenA.FinalistsTeams());

            IPhase RoundSixteenB = new RoundFinal();
            RoundSixteenB.TeamList.Add(groupPhaseTeams.FinalistGroupB.ToList()[0]);
            RoundSixteenB.TeamList.Add(groupPhaseTeams.FinalistGroupA.ToList()[1]);
            RoundSixteenB.start(nameof(RoundSixteenB));
            SixteenGroup.AddFinalistsGroupB(RoundSixteenB.FinalistsTeams());

            IPhase RoundSixteenC = new RoundFinal();
            RoundSixteenC.TeamList.Add(groupPhaseTeams.FinalistGroupC.ToList()[0]);
            RoundSixteenC.TeamList.Add(groupPhaseTeams.FinalistGroupD.ToList()[1]);
            RoundSixteenC.start(nameof(RoundSixteenC));
            SixteenGroup.AddFinalistsGroupC(RoundSixteenC.FinalistsTeams());

            IPhase RoundSixteenD = new RoundFinal();
            RoundSixteenD.TeamList.Add(groupPhaseTeams.FinalistGroupD.ToList()[0]);
            RoundSixteenD.TeamList.Add(groupPhaseTeams.FinalistGroupC.ToList()[1]);
            RoundSixteenD.start(nameof(RoundSixteenD));
            SixteenGroup.AddFinalistsGroupD(RoundSixteenD.FinalistsTeams());

            IPhase RoundSixteenE = new RoundFinal();
            RoundSixteenE.TeamList.Add(groupPhaseTeams.FinalistGroupE.ToList()[0]);
            RoundSixteenE.TeamList.Add(groupPhaseTeams.FinalistGroupF.ToList()[1]);
            RoundSixteenE.start(nameof(RoundSixteenE));
            SixteenGroup.AddFinalistsGroupE(RoundSixteenE.FinalistsTeams());

            IPhase RoundSixteenF = new RoundFinal();
            RoundSixteenF.TeamList.Add(groupPhaseTeams.FinalistGroupF.ToList()[0]);
            RoundSixteenF.TeamList.Add(groupPhaseTeams.FinalistGroupE.ToList()[1]);
            RoundSixteenF.start(nameof(RoundSixteenF));
            SixteenGroup.AddFinalistsGroupF(RoundSixteenF.FinalistsTeams());

            IPhase RoundSixteenG = new RoundFinal();
            RoundSixteenG.TeamList.Add(groupPhaseTeams.FinalistGroupG.ToList()[0]);
            RoundSixteenG.TeamList.Add(groupPhaseTeams.FinalistGroupH.ToList()[1]);
            RoundSixteenG.start(nameof(RoundSixteenF));
            SixteenGroup.AddFinalistsGroupG(RoundSixteenG.FinalistsTeams());

            IPhase RoundSixteenH = new RoundFinal();
            RoundSixteenH.TeamList.Add(groupPhaseTeams.FinalistGroupH.ToList()[0]);
            RoundSixteenH.TeamList.Add(groupPhaseTeams.FinalistGroupG.ToList()[1]);
            RoundSixteenH.start(nameof(RoundSixteenG));
            SixteenGroup.AddFinalistsGroupH(RoundSixteenH.FinalistsTeams());

            this.ShowRoundSexteenFinalists();
        }
        public void FillRoundEight()
        {
            IPhase RoundEightA = new RoundFinal();
            RoundEightA.TeamList.Add(SixteenGroup.SexteenFinalistA.ToList()[0]);
            RoundEightA.TeamList.Add(SixteenGroup.SexteenFinalistC.ToList()[0]);
            RoundEightA.start(nameof(RoundEightA));
            EightGroup.AddFinalistsGroupA(RoundEightA.FinalistsTeams());

            IPhase RoundEightB = new RoundFinal();
            RoundEightB.TeamList.Add(SixteenGroup.SexteenFinalistB.ToList()[0]);
            RoundEightB.TeamList.Add(SixteenGroup.SexteenFinalistD.ToList()[0]);
            RoundEightB.start(nameof(RoundEightB));
            EightGroup.AddFinalistsGroupB(RoundEightB.FinalistsTeams());

            IPhase RoundEightC = new RoundFinal();
            RoundEightC.TeamList.Add(SixteenGroup.SexteenFinalistE.ToList()[0]);
            RoundEightC.TeamList.Add(SixteenGroup.SexteenFinalistG.ToList()[0]);
            RoundEightC.start(nameof(RoundEightC));
            EightGroup.AddFinalistsGroupC(RoundEightC.FinalistsTeams());

            IPhase RoundEightD = new RoundFinal();
            RoundEightD.TeamList.Add(SixteenGroup.SexteenFinalistF.ToList()[0]);
            RoundEightD.TeamList.Add(SixteenGroup.SexteenFinalistH.ToList()[0]);
            RoundEightD.start(nameof(RoundEightD));
            EightGroup.AddFinalistsGroupD(RoundEightD.FinalistsTeams());

            this.ShowRoundEightFinalists();
        }
        public void FillSemiFinal()
        {
            IPhase SemiFinalA = new RoundFinal();
            SemiFinalA.TeamList.Add(EightGroup.EightFinalistA.ToList()[0]);
            SemiFinalA.TeamList.Add(EightGroup.EightFinalistC.ToList()[0]);
            SemiFinalA.start(nameof(SemiFinalA));
            SemiFinalGroup.AddFinalistsGroupA(SemiFinalA.FinalistsTeams());

            IPhase SemiFinalB = new RoundFinal();
            SemiFinalB.TeamList.Add(EightGroup.EightFinalistB.ToList()[0]);
            SemiFinalB.TeamList.Add(EightGroup.EightFinalistD.ToList()[0]);
            SemiFinalB.start(nameof(SemiFinalB));
            SemiFinalGroup.AddFinalistsGroupB(SemiFinalB.FinalistsTeams());

            this.ShowSemiFinalFinalists();  
        }       
        public void FillFinal()
        {
            IPhase Final = new RoundFinal();
            Final.TeamList.Add(SemiFinalGroup.SemiFinalistA.ToList()[0]);
            Final.TeamList.Add(SemiFinalGroup.SemiFinalistB.ToList()[0]);
            Final.start(nameof(Final));
            TeamWinner = Final.FinalistsTeams();

            this.ShowWinner();
        }

        private void ShowGroupsFinalists()
        {
            Console.WriteLine("We are the Finalist for round Sixteeen phase: ");
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
            Console.WriteLine($"{SixteenGroup.SexteenFinalistA.ToList()[0].Name} Vs {SixteenGroup.SexteenFinalistC.ToList()[0].Name}");
            Console.WriteLine($"{SixteenGroup.SexteenFinalistB.ToList()[0].Name} Vs {SixteenGroup.SexteenFinalistD.ToList()[0].Name}");
            Console.WriteLine($"{SixteenGroup.SexteenFinalistE.ToList()[0].Name} Vs {SixteenGroup.SexteenFinalistG.ToList()[0].Name}");
            Console.WriteLine($"{SixteenGroup.SexteenFinalistF.ToList()[0].Name} Vs {SixteenGroup.SexteenFinalistH.ToList()[0].Name}");
        }
        private void ShowRoundEightFinalists()
        {
            Console.WriteLine("We are the Finalist for semi final phase: ");
            Console.WriteLine($"{EightGroup.EightFinalistA.ToList()[0].Name} Vs {EightGroup.EightFinalistC.ToList()[0].Name}");
            Console.WriteLine($"{EightGroup.EightFinalistB.ToList()[0].Name} Vs {EightGroup.EightFinalistD.ToList()[0].Name}");
        }
        private void ShowSemiFinalFinalists()
        {
            Console.WriteLine("We are the Final: ");
            Console.WriteLine($"{SemiFinalGroup.SemiFinalistA.ToList()[0].Name} Vs {SemiFinalGroup.SemiFinalistB.ToList()[0].Name}");
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
