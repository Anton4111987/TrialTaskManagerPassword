using Microsoft.EntityFrameworkCore;
using TrialTaskManagerPassword.Models;

namespace TrialTaskManagerPassword.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
           //  Database.EnsureCreated();
        }


    }
}
