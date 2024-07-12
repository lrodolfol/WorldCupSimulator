namespace WorldCupSimulator.Class.Phase;
public class EightGroup
{
    private readonly List<Team> GroupEightFinalistA = new();
    private readonly List<Team> GroupEightFinalistB = new();
    private readonly List<Team> GroupEightFinalistC = new();
    private readonly List<Team> GroupEightFinalistD = new();

    public IReadOnlyCollection<Team> EightFinalistA => GroupEightFinalistA;
    public IReadOnlyCollection<Team> EightFinalistB => GroupEightFinalistB;
    public IReadOnlyCollection<Team> EightFinalistC => GroupEightFinalistC;
    public IReadOnlyCollection<Team> EightFinalistD => GroupEightFinalistD;

    public void AddFinalistsGroupA(List<Team> teams) =>
        GroupEightFinalistA.AddRange(teams);
    public void AddFinalistsGroupB(List<Team> teams) =>
        GroupEightFinalistB.AddRange(teams);

    public void AddFinalistsGroupC(List<Team> teams) =>
        GroupEightFinalistC.AddRange(teams);

    public void AddFinalistsGroupD(List<Team> teams) =>
        GroupEightFinalistD.AddRange(teams);

}
