using WorldCupSimulator.Enum;

namespace WorldCupSimulator
{
    public class Team
    {
        public int victories { get; set; }
        public int defeats { get; set; }    
        public int goals { get; set; }  
        public int Force {get;}
        public string Group { get; }
        public string Name { get; set; }
        public Status status { get; set; }
        public Phase phase { get; set; }

        public Team(string name, string group, int force)
        {
            this.Group = group;
            this.Name = name;   
            this.Force = force;
            this.status = Status.Playing;
            this.phase = Phase.Groups;
            this.goals = 0; 
            this.victories = 0; 
            this.defeats = 0;   
        }

    }
}