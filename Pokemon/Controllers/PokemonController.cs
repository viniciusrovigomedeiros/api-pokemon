using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApI.Controllers
{
    [Route("v0/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private PokemonRepository repo;

        public PokemonController()
        {
            this.repo = new PokemonRepository();
        }
        [HttpGet]
        public List<Pokemon> Get()
        {
            return repo.GetAll();  
        }
        [HttpPost]
        public string Post(Pokemon model)
        {
            return repo.Create(model);  
        }

    }
}
