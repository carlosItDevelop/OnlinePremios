using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Sorteio : EntityBase
    {
        protected Sorteio(int numero, DateTime dataInicial,
            DateTime dataSorteio, int qtdeCotas, decimal valorCotas)
        {
            this.Numero = numero;
            this.DataInicial = dataInicial;
            this.DataSorteio = dataSorteio;
            this.QtdeCotas = qtdeCotas;
            this.ValorCotas = valorCotas;
            this.StatusSorteio = StatusSorteio.Ativo;
        }

        // to EF
        public Sorteio() { }

        public int Numero { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataSorteio { get; private set; }
        public int QtdeCotas { get; private set; }
        public decimal ValorCotas { get; private set; }
        public StatusSorteio StatusSorteio { get; set; }

        public virtual IEnumerable<Cota> Cota { get; private set; }

        public void GerarCota(int numero, int QtdeCotas)
        {
            List<Cota> cotas = new List<Cota>();

            for (int i = numero; i < QtdeCotas; i++)

            {

                cotas.Add(new Cota(i)
                {
                    Numero = i,
                    StatusCota = StatusCota.Disponivel,
                    Valor = ValorCotas
                });
                //(int numero, Guid compraId, decimal valor)
            }
        }
    }
}
