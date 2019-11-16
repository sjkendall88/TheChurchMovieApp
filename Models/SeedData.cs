using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheChurchMovieApp.Data;

namespace TheChurchMovieApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TheChurchMovieAppContext(serviceProvider.GetRequiredService<DbContextOptions<TheChurchMovieAppContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = GenreList.Comedy,
                        Price = 9.99M,
                        Rating = "PG"
                    },

                    new Movies
                    {
                        Title = "Pirates of the Great Salt Lake",
                        ReleaseDate = DateTime.Parse("2006-2"),
                        Genre = GenreList.Adventure,
                        Price = 7.99M,
                        Rating = "PG-13"
                    },

                    new Movies
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-1-30"),
                        Genre = GenreList.Romance,
                        Price = 12.99M,
                        Rating = "PG"
                    },

                    new Movies
                    {
                        Title = "Midway to Heaven",
                        ReleaseDate = DateTime.Parse("2011-2-4"),
                        Genre = GenreList.Romance,
                        Price = 11.99M,
                        Rating = "PG"
                    },

                    new Movies
                    {
                        Title = "Scout Camp",
                        ReleaseDate = DateTime.Parse("2009-1-23"),
                        Genre = GenreList.Comedy,
                        Price = 8.99M,
                        Rating = "NR"
                    },

                    new Movies
                    {
                        Title = "The Singles 2nd Ward",
                        ReleaseDate = DateTime.Parse("2007-12-11"),
                        Genre = GenreList.Romance,
                        Price = 9.99M,
                        Rating = "NR"
                    },

                    new Movies
                    {
                        Title = "Entry Level",
                        ReleaseDate = DateTime.Parse("2007-8-12"),
                        Genre = GenreList.Comedy,
                        Price = 13.89M,
                        Rating = "NR"
                    },

                    new Movies
                    {
                        Title = "Believe",
                        ReleaseDate = DateTime.Parse("2007-4-20"),
                        Genre = GenreList.Comedy,
                        Price = 9.99M,
                        Rating = "PG"
                    },

                    new Movies
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = GenreList.Comedy,
                        Price = 12.99M,
                        Rating = "PG"
                    },

                    new Movies
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = GenreList.Adventure,
                        Price = 13.99M,
                        Rating = "PG"
                    },

                    new Movies
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2015-2-26"),
                        Genre = GenreList.Documentary,
                        Price = 8.99M,
                        Rating = "PG"
                    },

                    new Movies
                    {
                        Title = "The Other Side of Heaven2: Fire and Faith",
                        ReleaseDate = DateTime.Parse("2019-6-28"),
                        Genre = GenreList.Adventure,
                        Price = 19.99M,
                        Rating = "PG-13"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
