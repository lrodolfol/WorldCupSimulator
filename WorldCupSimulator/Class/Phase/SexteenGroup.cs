namespace WorldCupSimulator.Class.Phase;
public class SexteenGroup
{
    private readonly List<Team> GroupSexteeenFinalistA = new();
    private readonly List<Team> GroupSexteeenFinalistB = new();
    private readonly List<Team> GroupSexteeenFinalistC = new();
    private readonly List<Team> GroupSexteeenFinalistD = new();
    private readonly List<Team> GroupSexteeenFinalistE = new();
    private readonly List<Team> GroupSexteeenFinalistF = new();
    private readonly List<Team> GroupSexteeenFinalistG = new();
    private readonly List<Team> GroupSexteeenFinalistH = new();

    public IReadOnlyCollection<Team> SexteenFinalistA => GroupSexteeenFinalistA;
    public IReadOnlyCollection<Team> SexteenFinalistB => GroupSexteeenFinalistB;
    public IReadOnlyCollection<Team> SexteenFinalistC => GroupSexteeenFinalistC;
    public IReadOnlyCollection<Team> SexteenFinalistD => GroupSexteeenFinalistD;
    public IReadOnlyCollection<Team> SexteenFinalistE => GroupSexteeenFinalistE;
    public IReadOnlyCollection<Team> SexteenFinalistF => GroupSexteeenFinalistF;
    public IReadOnlyCollection<Team> SexteenFinalistG => GroupSexteeenFinalistG;
    public IReadOnlyCollection<Team> SexteenFinalistH => GroupSexteeenFinalistH;

    public void AddFinalistsGroupA(List<Team> teams) =>
        GroupSexteeenFinalistA.AddRange(teams);
    public void AddFinalistsGroupB(List<Team> teams) =>
        GroupSexteeenFinalistB.AddRange(teams);
    public void AddFinalistsGroupC(List<Team> teams) =>
        GroupSexteeenFinalistC.AddRange(teams);
    public void AddFinalistsGroupD(List<Team> teams) =>
        GroupSexteeenFinalistD.AddRange(teams);
    public void AddFinalistsGroupE(List<Team> teams) =>
        GroupSexteeenFinalistE.AddRange(teams);
    public void AddFinalistsGroupF(List<Team> teams) =>
        GroupSexteeenFinalistF.AddRange(teams);
    public void AddFinalistsGroupG(List<Team> teams) =>
        GroupSexteeenFinalistG.AddRange(teams);
    public void AddFinalistsGroupH(List<Team> teams) =>
        GroupSexteeenFinalistH.AddRange(teams);
}
