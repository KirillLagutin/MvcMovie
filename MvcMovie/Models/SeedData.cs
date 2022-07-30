using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var contex = new PagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<PagesMovieContext>>());

            if (contex.Movie.Any())
            {
                return;
            }

            contex.Movie.AddRange(
                new Movie
                {
                    Title = "111",
                    ReleaseDate = DateTime.Parse("11-11-2022"),
                    Genre = "zxc",
                    Price = 125.26M
                },
                new Movie
                {
                    Title = "222",
                    ReleaseDate = DateTime.Parse("12-01-2022"),
                    Genre = "vbn",
                    Price = 135.35M
                },
                new Movie
                {
                    Title = "333",
                    ReleaseDate = DateTime.Parse("13-04-2022"),
                    Genre = "bnm",
                    Price = 145.07M
                });
            contex.SaveChanges();
        }
    }
}
