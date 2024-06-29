namespace WorldCupSimulator.Interface
{
    public interface IPhase
    {
        public List<Team> TeamList { get; set; }
        void start(string phaseGroup);
        public List<Team> FinalistsTeams();
    }
}
