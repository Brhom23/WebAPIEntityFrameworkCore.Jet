using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class Context_MSAccess : DbContext
    {
       
        public DbSet<TodoItem> TodoItems { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\brhom\source\repos\ConsoleApp2\ConsoleApp2\Data\brm.accdb;");
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data/Data.accdb;");
        }

    }
}

