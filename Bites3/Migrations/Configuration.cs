namespace Bites3.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bites3.Models.BitesDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Bites3.Models.BitesDb";
        }

        protected override void Seed(Bites3.Models.BitesDb context)
        {
            context.Games.AddOrUpdate(r => r.Name,
                new Game { Name = "Super Mario World", Format = "Super Nintendo", Publisher = "Nintendo" },
                new Game { Name = "Super Mario 3D World", Format = "Wii U", Publisher = "Nintendo" },
                new Game
                {
                    Name = "Super Mario Bros.",
                    Format = "NES",
                    Publisher = "Nintendo",
                    Reviews = new List<Review> { new Models.Review { Body = "Fantastic game. I really enjoyed it!", ReviewerName = "Briain C"}
                }

                });
        }
    }
}
