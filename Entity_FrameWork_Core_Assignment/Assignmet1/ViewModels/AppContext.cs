using Assignmet1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignmet1.ViewModels
{
    public class AppContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=AccountDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
