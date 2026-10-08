using CorrecaoProvaH1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CorrecaoProvaH1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EleitoresController : ControllerBase
    {
        private readonly IEleitorRepository _repo;

        public EleitoresController(IEleitorRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult Cadastrar(Eleitor eleitor)
        {
            try
            {
                _repo.Adicionar(eleitor);
                return Ok("Eleitor cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Listar() => Ok(_repo.ListarTodos());
    }

}
