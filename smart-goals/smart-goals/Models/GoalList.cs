﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace smart_goals.Models
{
    public class GoalList
    { 
        public int GoalListId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ColourID { get; set; }
        public virtual User User { get; set; } = null!;

    }
}
