using Microsoft.EntityFrameworkCore;
using Tala7_3.Model;
using Tala7_3.Model.Profile;


namespace Tala7_3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Wallet_toman> Wallet_tomans { get; set; }

        public DbSet<Applicant> Applicants { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
