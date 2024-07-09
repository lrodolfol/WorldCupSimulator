using System.Collections.Generic;
using WorldCupSimulator.Exceptions;

namespace WorldCupSimulator.Class.Phase;
public class GroupPhaseTeams
{
    private readonly List<Team> GroupAList = new();
    private readonly List<Team> GroupBList = new();
    private readonly List<Team> GroupCList = new();
    private readonly List<Team> GroupDList = new();
    private readonly List<Team> GroupEList = new();
    private readonly List<Team> GroupFList = new();
    private readonly List<Team> GroupGList = new();
    private readonly List<Team> GroupHList = new();
    public IReadOnlyCollection<Team> GroupA => GroupAList;
    public IReadOnlyCollection<Team> GroupB => GroupAList;
    public IReadOnlyCollection<Team> GroupC => GroupAList;
    public IReadOnlyCollection<Team> GroupD => GroupAList;
    public IReadOnlyCollection<Team> GroupE => GroupAList;
    public IReadOnlyCollection<Team> GroupF => GroupAList;
    public IReadOnlyCollection<Team> GroupG => GroupAList;
    public IReadOnlyCollection<Team> GroupH => GroupAList;


    public readonly List<Team> FinalistsGroupAList = new();
    public readonly List<Team> FinalistsGroupBList = new();
    public readonly List<Team> FinalistsGroupCList = new();
    public readonly List<Team> FinalistsGroupDList = new();
    public readonly List<Team> FinalistsGroupEList = new();
    public readonly List<Team> FinalistsGroupFList = new();
    public readonly List<Team> FinalistsGroupGList = new();
    public readonly List<Team> FinalistsGroupHList = new();
    public IReadOnlyCollection<Team> FinalistGroupA => FinalistsGroupAList;
    public IReadOnlyCollection<Team> FinalistGroupB => FinalistsGroupBList;
    public IReadOnlyCollection<Team> FinalistGroupC => FinalistsGroupCList;
    public IReadOnlyCollection<Team> FinalistGroupD => FinalistsGroupDList;
    public IReadOnlyCollection<Team> FinalistGroupE => FinalistsGroupEList;
    public IReadOnlyCollection<Team> FinalistGroupF => FinalistsGroupFList;
    public IReadOnlyCollection<Team> FinalistGroupG => FinalistsGroupGList;
    public IReadOnlyCollection<Team> FinalistGroupH => FinalistsGroupHList;

    private void ValidateFinalists(IReadOnlyCollection<Team> team)
    {
        if (team is null)
            throw new CupException($"Team {nameof(team)} can not be null");

        if (team.Count >= 2)
            throw new CupException("Group already has two teams");
    }
    private void ValidateGroup(IReadOnlyCollection<Team> team)
    {
        if (team is null)
            throw new CupException($"Team group can not be null");

        if (team.Count >= 4)
            throw new CupException("Group already has four teams");
    }

    public void AddTeamGroupA(Team team)
    {
        ValidateGroup(GroupA);
        GroupAList.Add(team);
    }
    public void AddTeamGroupB(Team team)
    {
        ValidateGroup(GroupB);
        GroupBList.Add(team);
    }
    public void AddTeamGroupC(Team team)
    {
        ValidateGroup(GroupC);
        GroupCList.Add(team);
    }
    public void AddTeamGroupD(Team team)
    {
        ValidateGroup(GroupD);
        GroupDList.Add(team);
    }
    public void AddTeamGroupE(Team team)
    {
        ValidateGroup(GroupE);
        GroupEList.Add(team);
    }
    public void AddTeamGroupF(Team team)
    {
        ValidateGroup(GroupF);
        GroupFList.Add(team);
    }
    public void AddTeamGroupG(Team team)
    {
        ValidateGroup(GroupG);
        GroupGList.Add(team);
    }
    public void AddTeamGroupH(Team team)
    {
        ValidateGroup(GroupH);
        GroupHList.Add(team);
    }

    public void AddGroupAFinalists(List<Team> team)
    {
        ValidateFinalists(FinalistGroupA);
        team.ForEach(x =>
        {
            FinalistsGroupAList.Add(x);
        });
    }
    public void AddGroupBFinalists(List<Team> team)
    {
        ValidateFinalists(FinalistGroupB);
        team.ForEach(x =>
        {
            FinalistsGroupBList.Add(x);
        });
    }
    public void AddGroupCFinalists(List<Team> team)
    {
        ValidateFinalists(FinalistGroupC);
        team.ForEach(x =>
        {
            FinalistsGroupCList.Add(x);
        });
    }
    public void AddGroupDFinalists(List<Team> team)
    {
        ValidateFinalists(FinalistGroupD);
        team.ForEach(x =>
        {
            FinalistsGroupDList.Add(x);
        });
    }
    public void AddGroupEFinalists(List<Team> team)
    {
        ValidateFinalists(FinalistGroupE);
        team.ForEach(x =>
        {
            FinalistsGroupEList.Add(x);
        });
    }
    public void AddGroupFFinalists(List<Team> team)
    {
        ValidateFinalists(FinalistGroupF);
        team.ForEach(x =>
        {
            FinalistsGroupFList.Add(x);
        });
    }
    public void AddGroupGFinalists(List<Team> team)
    {
        ValidateFinalists(FinalistGroupG);
        team.ForEach(x =>
        {
            FinalistsGroupGList.Add(x);
        });
    }
}
