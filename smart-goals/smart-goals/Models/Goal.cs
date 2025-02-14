﻿using System.Text.Json.Serialization;
using smart_goals.Models;

namespace smart_goals.Models
{
    public class Goal
    {
        public int GoalId { get; set; }
        public string Name { get; set; } = string.Empty;
        
        //[JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly DueDate { get; set; }
        
        public int PriorityLevel { get; set; }
        public List<String> Tags { get; set; } = new List<string>();
        public string GeneralDescription { get; set; } = string.Empty;
        public GoalList GoalList { get; set; } = new GoalList();
        public string SuccessMetricDescription { get; set; } = string.Empty;


    }
}
