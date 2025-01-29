using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Justice_League_Profiles.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Hero> Heroes { get; private set; } = new List<Hero>();
        public List<Villain> Villains { get; private set; } = new List<Villain>(); // ✅ Added Villains list

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // ✅ Heroes Section
            Heroes = new List<Hero>
            {
                new Hero { Id = 1, Name = "Superman (Kal-EL, Clark Kent)", Description = "The Man of Steel, protector of Earth. Powers: Super-strength, flight, invulnerability, super speed, heat vision, freeze breath, x-ray vision, superhuman hearing, healing factor.", ImageUrl = "/images/superman.jpg", DcProfileUrl = "https://www.dc.com/characters/superman" },
                new Hero { Id = 2, Name = "Batman (Bruce Wayne)", Description = "The Dark Knight, defender of Gotham City.", ImageUrl = "/images/batman.jpg", DcProfileUrl = "https://www.dc.com/characters/batman" },
                new Hero { Id = 3, Name = "Wonder Woman (Diana Prince)", Description = "Princess Diana of Themyscira.", ImageUrl = "/images/wonderwoman.jpg", DcProfileUrl = "https://www.dc.com/characters/wonder-woman" },
                new Hero { Id = 4, Name = "The Flash (Barry Allen)", Description = "The fastest man alive.", ImageUrl = "/images/flash.jpg", DcProfileUrl = "https://www.dc.com/characters/the-flash" },
                new Hero { Id = 5, Name = "Aquaman (Arthur Curry)", Description = "The King of Atlantis.", ImageUrl = "/images/aquaman.jpg", DcProfileUrl = "https://www.dc.com/characters/aquaman" },
                new Hero { Id = 6, Name = "Green Lantern (Hal Jordan)", Description = "Protector of Sector 2814.", ImageUrl = "/images/greenlantern.jpg", DcProfileUrl = "https://www.dc.com/characters/green-lantern" },
                new Hero { Id = 7, Name = "Cyborg (Victor Stone)", Description = "Half man, half machine, all hero.", ImageUrl = "/images/cyborg.jpg", DcProfileUrl = "https://www.dc.com/characters/cyborg" },
                new Hero { Id = 8, Name = "Martian Manhunter (J'onn J'onzz)", Description = "J'onn J'onzz, the last Martian.", ImageUrl = "/images/martianmanhunter.jpg", DcProfileUrl = "https://www.dc.com/characters/martian-manhunter" },   
                new Hero { Id = 9, Name = "Green Arrow (Oliver Queen)", Description = "Master archer.", ImageUrl = "/images/greenarrow.jpg", DcProfileUrl = "https://www.dc.com/characters/green-arrow" }
            };

            // ✅ Villains Section
            Villains = new List<Villain>
            {
                new Villain { Id = 1, Name = "Darkseid", Description = "The ruler of Apokolips and a god-like conqueror. Powers: Super strength, invulnerability, genius-level intellect, combat strategy, alien technology, teleportation, energy blasts", ImageUrl = "/images/darkseid.jpg", DcProfileUrl = "https://www.dc.com/characters/darkseid" },
                new Villain { Id = 2, Name = "The Joker", Description = "Gotham's Clown Prince of Crime. Powers: Complete unpredictability, chaos agent, customized weapons, wields toxin which causes victims to die laughing", ImageUrl = "/images/thejoker.jpg", DcProfileUrl = "https://www.dc.com/characters/joker" },
                new Villain { Id = 3, Name = "Doomsday", Description = "A weapon crafted in the most extreme conditions imaginable Powers: super strength, invulnerability, super speed, healing factor, superhuman agility, toxikinesis", ImageUrl = "/images/doomsday.jpg", DcProfileUrl = "https://www.dc.com/characters/doomsday" },
                new Villain { Id = 4, Name = "Reverse-Flash (Eobard Thawne)", Description = "Time-traveling nemesis of The Flash. Powers: Granted with powers and abilities similar to that of the Flash", ImageUrl = "/images/reverseflash.jpg", DcProfileUrl = "https://www.dc.com/characters/reverse-flash" },
                new Villain { Id = 5, Name = "Black Manta", Description = "Aquaman's greatest enemy is the scourge of the seven seas. Powers: Enhanced strength, energy blasts, skilled fighter, unrivaled swimmer, master swordsman, advanced technology, intelligence.", ImageUrl = "/images/blackmanta.jpg", DcProfileUrl = "https://www.dc.com/characters/black-manta" },
                new Villain { Id = 6, Name = "Sinestro", Description = "From the greatest Green Lantern to the Corps' greatest enemy. Powers: Wields a yellow power ring that is functionally similar to those of the Green Lanterns, granting him flight, the ability to survive in any environment and the ability to create constructs of any shape and size.", ImageUrl = "/images/sinestro.jpg", DcProfileUrl = "https://www.dc.com/characters/sinestro" },
                new Villain { Id = 7, Name = "Deathstroke", Description = "Slade Wilson is a mercenary and assassin for hire with no qualms about crossing lines to get the job done Powers: Exceptional martial artist, combat strategy, durability, enhanced strength and speed, weapons expert, superhuman agility, master swordsman", ImageUrl = "/images/deathstroke.jpg", DcProfileUrl = "https://www.dc.com/characters/deathstroke " },
                new Villain { Id = 8, Name = "Black Adam", Description = "Ancient anti-hero with god-like powers. Powers: Immortality, super strength, super speed, invulnerability, flight, magic, teleportation, healing factor", ImageUrl = "/images/blackadam.jpg", DcProfileUrl = "https://www.dc.com/characters/black-adam" },
                new Villain { Id = 9, Name = "Brainiac", Description = "Super-intelligent alien conqueror. Powers: Alien technology, genius-level intellect", ImageUrl = "/images/brainiac.jpg", DcProfileUrl = "https://www.dc.com/characters/brainiac" }
            };
        }
    }

    public class Hero
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string DcProfileUrl { get; set; }
    }

    public class Villain //New Villain class added
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string DcProfileUrl { get; set; }
    }
}





