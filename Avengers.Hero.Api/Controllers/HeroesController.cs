using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Avengers.Heroes.Domain.Services;

namespace Avengers.Hero.Api.Controllers
{
    [Route("api/v1/heroes")]
    [ApiController]
    public class HeroesController : ControllerBase
    {

        private IHeroesService _heroesService;

        public HeroesController(IHeroesService heroesService)
        {
            _heroesService = heroesService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string[]> Get()
        {
            return _heroesService.GetHeroes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetAsync(int id)
        {
            return _heroesService.GetHero(id);
        }
    }
}
