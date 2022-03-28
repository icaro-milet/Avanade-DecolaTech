using Avanade.Arquitetura.DecolaTech.Domain.Entidades;
using Avanade.Arquitetura.DecolaTech.Domain.Interfaces;
using Avanade.Arquitetura.DecolaTech.Infra.Database;
using Microsoft.AspNetCore.Mvc;

namespace Avanade.Arquitetura.DecolaTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;

        private readonly IRepositorio<Pessoa> _repositorio;

        public PessoaController(
            ILogger<PessoaController> logger,
            IRepositorio<Pessoa> repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Domain.Entidades.Pessoa> Obter()
        {
            return _repositorio.Listar();
        }

        [HttpGet("{id}")]
        public Domain.Entidades.Pessoa ObterPorId([FromRoute] int id)
        {
            return _repositorio.ObterPorId(id);
        }

        [HttpPost]
        public void CadastrarPessoa([FromBody] Domain.Entidades.Pessoa pessoa)
        {
            _repositorio.Cadastrar(pessoa);
        }

        [HttpPut("{id}")]
        public void AtualizarPessoa([FromRoute] int id, [FromBody] Domain.Entidades.Pessoa pessoa)
        {
            _repositorio.Atualizar(id, pessoa);
        }

        [HttpDelete("{id}")]
        public void DeletarPessoa([FromRoute] int id)
        {
            _repositorio.Deletar(id);
        }
    }
}
