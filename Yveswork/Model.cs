using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yveswork
{
    public class YvesworkContext : DbContext
    {
        public DbSet<Yvesworktbl> Yvesworks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.Yveswork;Trusted_Connection=True;");
        }
    }

    public class Yvesworktbl
    {
        [Key]
        public int YvesworkId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}