using EF_Core_Survivor.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Survivor.Context
{
    public class SurvivorDbContext : DbContext
    {

        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base (options)
        {
            
        }

        public DbSet<CompetitorEntity> Competitors { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }



    }
}
