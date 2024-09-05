using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace AnimalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        IService<Animal> _services;

        public AnimaisController(IService<Animal> services)
        {
            _services = services;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            try
            {
                return _services.ObterTodos(); ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Animal> GetGato(int id)
        {
            try
            {
                Animal animal = new Gato { ID = id };
                return _services.Obter(animal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("EmitirSom")]
        public ActionResult<string> EmitirSom([FromBody] Gato gato)
        {
            try
            {
                return gato.EmitirSom();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] Animal animal)
        {
            try
            {
                _services.Inserir(animal);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut()]
        public IActionResult Put([FromBody] Animal animal)
        {
            try
            {
                _services.Atualizar(animal);
                return Ok("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete()]
        public IActionResult Delete([FromBody] Animal animal)
        {
            try
            {
                _services.Remover(animal);
                return Ok("Removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}