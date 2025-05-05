using DiziFilmUygulamas.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DiziFilmUygulamas
{
    public class MovieRatingContext : DbContext
    {
        public MovieRatingContext(DbContextOptions<MovieRatingContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
