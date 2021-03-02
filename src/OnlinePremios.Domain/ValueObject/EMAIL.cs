using OnlinePremios.Domain.Core;

namespace OnlinePremios.Domain.ValueObject
{
    public class EMAIL : EntityBase
    {
        public string Descricao { get; set; }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
