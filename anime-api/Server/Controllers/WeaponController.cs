using animeapi.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace animeapi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : ControllerBase
    {
        private static List<Weapon> Weapons = new List<Weapon>{
            new Weapon {
                Id = "2",
                Name = "dogshit",
                Description = "dogshit"
            },
            new Weapon {
                Id = "3",
                Name = "dogshit1",
                Description = "dogshit"
            },
            new Weapon {
                Id = "5",
                Name = "dogshit2",
                Description = "dogshit"
            }
        };
        [HttpGet]
        public async Task<IActionResult> GetWeapon()
        {
            return Ok(Weapons);
        }
    }
}
