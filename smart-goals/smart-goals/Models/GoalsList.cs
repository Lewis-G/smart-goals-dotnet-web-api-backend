using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace smart_goals.Models
{
    public class GoalsList
    {

        public int GoalsListId { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ColourID { get; set; }

        //[JsonIgnore]
        //public virtual User User { get; set; } = null!;

    }
}
