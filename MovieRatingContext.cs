using DiziFilmUygulaması.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DiziFilmUygulaması
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
