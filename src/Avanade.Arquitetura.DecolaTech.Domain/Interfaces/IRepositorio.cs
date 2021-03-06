namespace Avanade.Arquitetura.DecolaTech.Domain.Interfaces
{
    public interface IRepositorio<TEntity>
    {
        IEnumerable<TEntity> Listar();

        TEntity ObterPorId(int id);

        void Cadastrar(TEntity entidade);

        void Atualizar(int id, TEntity entidade);

        public void Deletar(int id);
    }
}
