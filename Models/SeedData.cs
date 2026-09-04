using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using W02_Assignment_ASP.NET_Core.Data;
using W02_Assignment_ASP.NET_Core.Models;
using System;
using System.Linq;
 
namespace W02_Assignment_ASP.NET_Core.Models;
 
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Genre = "Science Fiction",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Interstellar",
                    ReleaseDate = DateTime.Parse("2014-11-7"),
                    Genre = "Science Fiction",
                    Rating = "PG-13",
                    Price = 10.99M
                }
            );
            context.SaveChanges();
        }
    }
}