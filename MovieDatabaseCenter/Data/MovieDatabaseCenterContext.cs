using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieDatabaseCenter.Models;

namespace MovieDatabaseCenter.Data
{
    public class MovieDatabaseCenterContext : DbContext
    {
        public MovieDatabaseCenterContext (DbContextOptions<MovieDatabaseCenterContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDatabaseCenter.Models.Movie> Movie { get; set; }
    }
}
