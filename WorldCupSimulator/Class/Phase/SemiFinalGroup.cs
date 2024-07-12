namespace WorldCupSimulator.Class.Phase;
public class SemiFinalGroup
{
    private readonly List<Team> GroupSemiFinalistA = new();
    private readonly List<Team> GroupSemiFinalistB = new();

    public IReadOnlyCollection<Team> SemiFinalistA => GroupSemiFinalistA;
    public IReadOnlyCollection<Team> SemiFinalistB => GroupSemiFinalistB;

    public void AddFinalistsGroupA(List<Team> teams) =>
        GroupSemiFinalistA.AddRange(teams);
    public void AddFinalistsGroupB(List<Team> teams) =>
        GroupSemiFinalistB.AddRange(teams);
}
