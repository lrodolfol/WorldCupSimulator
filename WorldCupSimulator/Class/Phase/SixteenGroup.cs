namespace WorldCupSimulator.Class.Phase;
public class SixteenGroup
{
    private readonly List<Team> GroupSixteeenFinalistA = new();
    private readonly List<Team> GroupSixteeenFinalistB = new();
    private readonly List<Team> GroupSixteeenFinalistC = new();
    private readonly List<Team> GroupSixteeenFinalistD = new();
    private readonly List<Team> GroupSixteeenFinalistE = new();
    private readonly List<Team> GroupSixteeenFinalistF = new();
    private readonly List<Team> GroupSixteeenFinalistG = new();
    private readonly List<Team> GroupSixteeenFinalistH = new();

    public IReadOnlyCollection<Team> SexteenFinalistA => GroupSixteeenFinalistA;
    public IReadOnlyCollection<Team> SexteenFinalistB => GroupSixteeenFinalistB;
    public IReadOnlyCollection<Team> SexteenFinalistC => GroupSixteeenFinalistC;
    public IReadOnlyCollection<Team> SexteenFinalistD => GroupSixteeenFinalistD;
    public IReadOnlyCollection<Team> SexteenFinalistE => GroupSixteeenFinalistE;
    public IReadOnlyCollection<Team> SexteenFinalistF => GroupSixteeenFinalistF;
    public IReadOnlyCollection<Team> SexteenFinalistG => GroupSixteeenFinalistG;
    public IReadOnlyCollection<Team> SexteenFinalistH => GroupSixteeenFinalistH;

    public void AddFinalistsGroupA(List<Team> teams) =>
        GroupSixteeenFinalistA.AddRange(teams);
    public void AddFinalistsGroupB(List<Team> teams) =>
        GroupSixteeenFinalistB.AddRange(teams);
    public void AddFinalistsGroupC(List<Team> teams) =>
        GroupSixteeenFinalistC.AddRange(teams);
    public void AddFinalistsGroupD(List<Team> teams) =>
        GroupSixteeenFinalistD.AddRange(teams);
    public void AddFinalistsGroupE(List<Team> teams) =>
        GroupSixteeenFinalistE.AddRange(teams);
    public void AddFinalistsGroupF(List<Team> teams) =>
        GroupSixteeenFinalistF.AddRange(teams);
    public void AddFinalistsGroupG(List<Team> teams) =>
        GroupSixteeenFinalistG.AddRange(teams);
    public void AddFinalistsGroupH(List<Team> teams) =>
        GroupSixteeenFinalistH.AddRange(teams);
}
