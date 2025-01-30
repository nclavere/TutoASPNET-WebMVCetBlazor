using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutoDebutantBlazor.Entities;

namespace TutoDebutantBlazor.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<TutoDebutantBlazor.Entities.Movie> Movie { get; set; } = default!;
    }
}
