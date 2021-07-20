using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext :DbContext
    {
        internal readonly object Activities;

        public DataContext (DbContextOptions options) :base (options)
        {
        }

        public DbSet<activity> Activites { get; set; }

    }
}