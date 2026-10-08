using CorrecaoProvaH1.Interfaces;
using CorrecaoProvaH1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorrecaoProvaH1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JustificativasController : ControllerBase
    {
        private readonly IJustificativaRepository _repoJust;
        private readonly IEleitorRepository _repoEleitor;

        public JustificativasController(IJustificativaRepository repoJust, IEleitorRepository repoEleitor)
        {
            _repoJust = repoJust;
            _repoEleitor = repoEleitor;
        }

        [HttpPost]
        public IActionResult Registrar(Justificativa justificativa)
        {
            var eleitor = _repoEleitor.ObterPorCPF(justificativa.CPF);
            if (eleitor == null)
                return NotFound("Eleitor não encontrado.");

            try
            {
                _repoJust.Adicionar(justificativa);
                return Ok("Justificativa registrada com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Listar() => Ok(_repoJust.ListarTodas());
    }

}
