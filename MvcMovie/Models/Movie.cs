using MvcMovie.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext()
        {
            Database.SetInitializer<MovieDBContext>
                (new MigrateDatabaseToLatestVersion<MovieDBContext,
                    MvcMovie.Migrations.Configuration>());
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
