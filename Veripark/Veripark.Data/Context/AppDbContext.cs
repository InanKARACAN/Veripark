using Microsoft.EntityFrameworkCore;
using Veripark.Entity.Entities;

namespace Veripark.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MusteriTip> MusteriTipler { get; set; }
        public DbSet<OlayOncelik> OlayOncelikler { get; set; }
        public DbSet<OlayTip> OlayTipler { get; set; }
        public DbSet<Sikayet> Sikayetler { get; set; }
    }
}
