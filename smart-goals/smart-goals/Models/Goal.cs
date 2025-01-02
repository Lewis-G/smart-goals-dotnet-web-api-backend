using System.Text.Json.Serialization;

namespace smart_goals.Models
{
    public class Goal
    {
        public int GoalID { get; set; }
        public string Name { get; set; } = string.Empty;
        
        //[JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly Date { get; set; }
        
        public int TierLevel { get; set; }
        public int PriorityLevel { get; set; }
        public List<String> Tags { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        // public GoalList GoalList = New GoalList();
        //public Goal ParentGoal { get; set; }
        //public List<Goal> ChildGoals { get; set; }
        //public int/string Measure { get; set; }


    }
}
