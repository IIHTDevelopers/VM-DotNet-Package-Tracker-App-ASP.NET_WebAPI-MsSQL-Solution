
using PackageTrackerApp.Models;
using System.Data.Entity;


namespace PackageTrackerApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Package> Packages { get; set; }
    }
}