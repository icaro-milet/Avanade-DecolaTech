namespace Avanade.Arquitetura.DecolaTech.Infra.Database
{
    public class PessoaRepositorio
    {
        private readonly string _connMongo;
        private readonly string _databaseMongo;

        static List<Domain.Entidades.Pessoa> banco = new List<Domain.Entidades.Pessoa>();

        public PessoaRepositorio()
        {

        }

        public IEnumerable<Domain.Entidades.Pessoa> Listar() 
        {
            return banco.ToList();
        }

        public Domain.Entidades.Pessoa ObterPorId(int idPessoa) 
        {
            return banco.FirstOrDefault(x => x.Id == idPessoa);
        }

        public void CadastrarPessoa(Domain.Entidades.Pessoa pessoa) 
        {
            banco.Add(pessoa);
        }

        public void AtualizarPessoa(int idPessoa, Domain.Entidades.Pessoa pessoa)
        {
            var item = banco.FirstOrDefault(p => p.Id == idPessoa);

            if (item is not null)
            {
                item.Nascimento = pessoa.Nascimento;
                item.Nome = pessoa.Nome;
                item.Salario = pessoa.Salario;
                item.Trem = pessoa.Trem;
            }
            else
            {
                throw new Exception($"Pessoa id {idPessoa} não existe na base de dados.");
            }
        }

        public void DeletarPessoa(int idPessoa)
        {
            var pessoa = banco.FirstOrDefault(p => p.Id == idPessoa);

            banco.Remove(pessoa);
        }

    }
}
