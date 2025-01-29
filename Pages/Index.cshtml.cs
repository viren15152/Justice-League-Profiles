using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Justice_League_Profiles.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Hero> Heroes { get; private set; } = new List<Hero>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Heroes = new List<Hero>
            {
                new Hero { Id = 1, Name = "Superman (Kal-EL, Clark Kent)", Description = "The Man of Steel, protector of Earth. Powers: Super-strength, flight, invulnerability, super speed, heat vision, freeze breath, x-ray vision, superhuman hearing, healing factor.", ImageUrl = "/images/superman.jpg", DcProfileUrl = "https://www.dc.com/characters/superman" },
                new Hero { Id = 2, Name = "Batman (Bruce Wayne)", Description = "The Dark Knight, defender of Gotham City. Powers: Batman does not have any metahuman abilities. Instead, he relies on his sharp mind and disciplined body, as well as his extensive combat and detective training. A master of virtually every form of martial arts, a brilliant tactician and a genius-level forensic scientist.", ImageUrl = "/images/batman.jpg", DcProfileUrl = "https://www.dc.com/characters/batman" },
                new Hero { Id = 3, Name = "Wonder Woman (Diana Prince)", Description = "Princess Diana of Themyscira. Powers: Super strength, invulnerability, flight, combat skill, combat strategy, superhuman agility, healing factor, magic weaponry.", ImageUrl = "/images/wonderwoman.jpg", DcProfileUrl = "https://www.dc.com/characters/wonder-woman" },
                new Hero { Id = 4, Name = "The Flash (Barry Allen)", Description = "The fastest man alive. Powers: Super speed, intangibility, superhuman agility, time travel, creates and controls lightning, multiversal knowledge", ImageUrl = "/images/flash.jpg", DcProfileUrl = "https://www.dc.com/characters/the-flash" },
                new Hero { Id = 5, Name = "Aquaman (Arthur Curry)", Description = "The King of Atlantis. Powers: Super strength, durability, control over sea life, exceptional swimming ability, ability to breathe underwater", ImageUrl = "/images/aquaman.jpg", DcProfileUrl = "https://www.dc.com/characters/aquaman" },
                new Hero { Id = 6, Name = "Green Lantern (Hal Jordan)", Description = "Protector of Sector 2814. Powers: Hard light constructs, instant weaponry, force fields, flight, durability, alien technology", ImageUrl = "/images/greenlantern.jpg", DcProfileUrl = "https://www.dc.com/characters/green-lantern" },
                new Hero { Id = 7, Name = "Cyborg (Victor Stone)", Description = "Half man, half machine, all hero. Powers: Super strength, advanced technology, instant weaponry, genius-level intellect, control over technology, computer hacking, durability, teleportation", ImageUrl = "/images/cyborg.jpg", DcProfileUrl = "https://www.dc.com/characters/cyborg" },
                new Hero { Id = 8, Name = "Martian Manhunter (J'onn J'onzz)", Description = "J'onn J'onzz, the last Martian. Powers: Flight, super strength, invulnerability, enhanced speed, shapeshifting, invisibility, telepathy, telekinesis, intelligence, intangibility, optic blasts", ImageUrl = "/images/martianmanhunter.jpg", DcProfileUrl = "https://www.dc.com/characters/martian-manhunter" },   
                new Hero { Id = 9, Name = "Green Arrow (Oliver Queen)", Description = "Master archer. Powers: Archery, unrivaled aim, exceptional martial artist, inexhaustible wealth. Billionaire Oliver Queen uses both his wealth and his unmatched archery skills as the Justice League's battling bowman, Green Arrow.", ImageUrl = "/images/greenarrow.jpg", DcProfileUrl = "https://www.dc.com/characters/green-arrow" }
            };
        }
    }

    public class Hero
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string DcProfileUrl { get; set; } // ✅ Added this property for the DC Comics website link
    }
}




