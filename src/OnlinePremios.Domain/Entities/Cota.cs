using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Cota : EntityBase
    {
        public Cota(int numero, Guid compraId, decimal valor)
        {
            this.Numero = numero;
            this.CompraId = compraId;
            this.Valor = valor;
            this.StatusCota = StatusCota.Disponivel;
        }

        // to EF
        public Cota() { }

        public int Numero { get; private set; }
        public decimal Valor { get; private set; }
        public StatusCota StatusCota { get; private set; }
        public Guid CompraId { get; private set; }

        public virtual Compra Compra { get; set; }


        // Todo: Cotas para pertencer a Compra, precisa ter outra denominação, ainda que seja a mesma Cota que pegamos do Sorteio.
        // Todo: Preciso mexer no Map, na Model Compra, nos Services e Repositories;
        // Todo: Já adicioei uma coleção de Cotas no Sorteio => IEnumerable<Cota> Cota (in Sorteio);

    }
}
