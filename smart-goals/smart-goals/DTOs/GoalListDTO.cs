using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_goals.DTOs
{
    public class GoalListDTO
    {
        public int GoalListId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ColourID { get; set; }
    }
}
