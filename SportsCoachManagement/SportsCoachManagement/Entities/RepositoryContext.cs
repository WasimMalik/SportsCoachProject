using Microsoft.EntityFrameworkCore;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<TestDetails> TestDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<sp_TestDetail> sp_TestDetail { get; set; }
        public DbSet<spTotalParticipants> spTotalParticipants { get; set; }
    }
}
