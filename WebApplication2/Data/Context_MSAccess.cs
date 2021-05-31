using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class Context_MSAccess : DbContext
    {
        //public Context_MSAccess(DbContextOptions<Context_MSAccess> options)
        //    : base(options)
        //{
        //}
        public Context_MSAccess() : base()
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\brhom\source\repos\ConsoleApp2\ConsoleApp2\Data\brm.accdb;");
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data/Data.accdb;");
        }

    }
}

