using OnlinePremios.Domain.Core;

namespace OnlinePremios.Domain.Entities
{
    public class Revendedor : EntityBase
    {
        // To EF
        public Revendedor() {}

        public Revendedor(string nome, string cpf)
        {
            this.Nome = nome;
            this.cpf = cpf;

        }

        public string Nome { get; private set; }
        public string cpf { get; private set; }
        public string Rg { get; private set; }
    }
}
