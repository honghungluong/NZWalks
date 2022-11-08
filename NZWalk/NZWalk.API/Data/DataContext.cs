using Microsoft.EntityFrameworkCore;
using NZWalk.API.Models.Domain;

namespace NZWalk.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        // tellling EF that if a table doenst exist please create a table
        DbSet<Region> Regions { get; set; }
        DbSet<Walk> Walks { get; set; }
        DbSet<WalkDiffculty> WalkDiffculties { get; set; }

    }
}
