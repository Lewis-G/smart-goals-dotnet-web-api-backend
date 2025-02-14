using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_goals.DTOs
{
    public class GoalDTO
    {
        public int GoalId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly DueDate { get; set; }
        public int PriorityLevel { get; set; }
        public List<String> Tags { get; set; } = new List<string>();
        public string GeneralDescription { get; set; } = string.Empty;
        public string SuccessMetricDescription { get; set; } = string.Empty;

    }
}
