using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Justice_League_Profiles.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // ✅ FIX: Initialize Heroes to an empty list to avoid nullability warnings
        public List<Hero> Heroes { get; private set; } = new List<Hero>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Heroes = new List<Hero>
            {
                new Hero { Id = 1, Name = "Superman", Description = "The Man of Steel, protector of Metropolis.", ImageUrl = "/images/superman.jpg" },
                new Hero { Id = 2, Name = "Batman", Description = "The Dark Knight, defender of Gotham City.", ImageUrl = "/images/batman.jpg" },
                new Hero { Id = 3, Name = "Wonder Woman", Description = "Amazon warrior princess.", ImageUrl = "/images/wonderwoman.jpg" },
                new Hero { Id = 4, Name = "The Flash", Description = "The fastest man alive.", ImageUrl = "/images/flash.jpg" },
                new Hero { Id = 5, Name = "Aquaman", Description = "The King of Atlantis.", ImageUrl = "/images/aquaman.jpg" },
                new Hero { Id = 6, Name = "Green Lantern", Description = "Protector of Sector 2814.", ImageUrl = "/images/greenlantern.jpg" },
                new Hero { Id = 7, Name = "Cyborg", Description = "Half man, half machine, all hero.", ImageUrl = "/images/cyborg.jpg" }
            };
        }
    }

    public class Hero
    {
        public int Id { get; set; }

        // ✅ FIX: Add `required` modifier to enforce non-null values
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
    }
}


