using Microsoft.EntityFrameworkCore;
using RankingServer.Models;

namespace RankingServer.Data
{
    public class RankingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source='ranking.db'");
        }

        public DbSet<ScoreData> ScoreData { get; set; }
    }
}
