namespace Avanade.Arquitetura.DecolaTech.Domain.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public Decimal Salario { get; set; }

        public IEnumerable<string> Trem { get; set; }
    }
}
