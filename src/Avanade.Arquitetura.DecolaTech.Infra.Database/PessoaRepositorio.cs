using Avanade.Arquitetura.DecolaTech.Domain.Entidades;
using Avanade.Arquitetura.DecolaTech.Domain.Interfaces;

namespace Avanade.Arquitetura.DecolaTech.Infra.Database
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        List<Domain.Entidades.Pessoa> _banco;

        public PessoaRepositorio()
        {
            _banco = new List<Domain.Entidades.Pessoa>();
        }

        public void Atualizar(int id, Pessoa entidade)
        {
            var item = _banco.FirstOrDefault(p => p.Id == id);

            if (item is not null)
            {
                item.Nascimento = entidade.Nascimento;
                item.Nome = entidade.Nome;
                item.Salario = entidade.Salario;
                item.Trem = entidade.Trem;
            }
            else
            {
                throw new Exception($"Entidade id {id} não existe na base de dados");
            }
        }

        public void Cadastrar(Pessoa entidade)
        {
            _banco.Add(entidade);
        }

        public void Deletar(int id)
        {
            _banco.Remove(_banco.FirstOrDefault(p => p.Id == id));
        }

        public IEnumerable<Pessoa> Listar()
        {
            return _banco.ToList();
        }

        public Pessoa ObterPorId(int id)
        {
            return _banco.FirstOrDefault(p => p.Id == id);
        }

    }
}
