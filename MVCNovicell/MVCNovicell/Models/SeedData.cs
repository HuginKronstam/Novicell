using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
//Seeding purpose, if database is empty, the following are added.
namespace MVCNovicell.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCNovicellContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCNovicellContext>>()))
            {
                // Look for any games.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "Dota 2",
                        ReleaseDate = DateTime.Parse("2013-07-13"),
                        Genre = "Moba",
                        Score = 9
                    },

                    new Game
                    {
                        Title = "Minecraft (modded)",
                        ReleaseDate = DateTime.Parse("2009-05-17"),
                        Genre = "Sandbox",
                        Score = 7
                    },

                    new Game
                    {
                        Title = "Path of Exile",
                        ReleaseDate = DateTime.Parse("2013-10-23"),
                        Genre = "Hack N' Slash",
                        Score = 8
                    },

                    new Game
                    {
                        Title = "Super Mario Bros. 3",
                        ReleaseDate = DateTime.Parse("1988-10-23"),
                        Genre = "Platformer",
                        Score = 10
                    }
                );
                context.SaveChanges();
            }
        }
    }
}