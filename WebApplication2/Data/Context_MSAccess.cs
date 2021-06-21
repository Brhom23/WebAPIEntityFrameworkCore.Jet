using Microsoft.EntityFrameworkCore;
using WebAPIEntityFrameworkCoreJet.Models;

namespace WebAPIEntityFrameworkCoreJet.Data
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

            //optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/brm/brm.accdb;");
            optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data/Data.accdb;");
        }

    }
}

