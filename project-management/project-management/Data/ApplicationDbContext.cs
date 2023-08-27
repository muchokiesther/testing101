using Microsoft.EntityFrameworkCore;
using project_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_management.Data
{
    public class ApplicationDbContext:DbContext
           
    {
        public DbSet<tasks> tasks { get; set; }
        public DbSet<project> project { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-Q8FU87I\\SQLEXPRESS; database = Project-Management-System; TrustServerCertificate = true; Trusted_Connection = true; user Id  = sa; password = wamuyu@2023 ");//connecting to my database
        }
    }
}
