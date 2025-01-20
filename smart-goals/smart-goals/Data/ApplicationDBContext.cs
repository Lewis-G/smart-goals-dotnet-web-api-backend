using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smart_goals.Models;

namespace smart_goals.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalList> GoalLists { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
