using Avanade.Arquitetura.DecolaTech.Infra.Database;
using Microsoft.AspNetCore.Mvc;

namespace Avanade.Arquitetura.DecolaTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Domain.Entidades.Pessoa> Obter()
        {
            PessoaRepositorio pessoaRepositorio = new();

            return pessoaRepositorio.Listar();
        }

        [HttpGet("{id}")]
        public Domain.Entidades.Pessoa ObterPorId([FromRoute] int id)
        {
            PessoaRepositorio pessoaRepositorio = new();

            return pessoaRepositorio.ObterPorId(id);
        }

        [HttpPost]
        public void CadastrarPessoa([FromBody] Domain.Entidades.Pessoa pessoa)
        {
            PessoaRepositorio pessoaRepositorio = new();

            pessoaRepositorio.CadastrarPessoa(pessoa);
        }

        [HttpPut("{id}")]
        public void AtualizarPessoa([FromRoute] int id, [FromBody] Domain.Entidades.Pessoa pessoa)
        {
            PessoaRepositorio pessoaRepositorio = new();

            pessoaRepositorio.AtualizarPessoa(id, pessoa);
        }

        [HttpDelete("{id}")]
        public void DeletarPessoa([FromRoute] int id)
        {
            PessoaRepositorio pessoaRepositorio = new();

            pessoaRepositorio.DeletarPessoa(id);
        }
    }
}
