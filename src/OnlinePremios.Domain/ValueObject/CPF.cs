using OnlinePremios.Domain.Core;

namespace OnlinePremios.Domain.ValueObject
{
    public class CPF : EntityBase
    {
        public string Numero { get; private set; }

        public override string ToString()
        {
            return this.Numero;
        }

    }
}
