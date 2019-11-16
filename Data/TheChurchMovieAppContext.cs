using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheChurchMovieApp.Models;

namespace TheChurchMovieApp.Data
{
    public class TheChurchMovieAppContext : DbContext
    {

        public TheChurchMovieAppContext(DbContextOptions<TheChurchMovieAppContext> options) : base(options)
        {

        }

        public DbSet<Movies> Movies { get; set; }

        public IEnumerable<GenreList> GenreList { get; }
    }
}
