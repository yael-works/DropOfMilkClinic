using DropOfMilkClinic.Entities;
using Microsoft.EntityFrameworkCore;

namespace DropOfMilkClinic.Data
{
    public class DataContex : DbContext
    {

        public DbSet<Baby> Baby { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Nurse> Nurse { get; set; }
        public DbSet<Turn> Turn { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DropOfMilkClinic");
           // optionsBuilder.LogTo(m => Console.WriteLine(m));
        }

    }
}
