using OnlinePremios.Domain.Core;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Sorteio : EntityBase
    {
        protected Sorteio(int numero, DateTime dataInicial, DateTime dataSorteio, int qtdeCotas, int status)
        {
            this.Numero = numero;
            this.DataInicial = dataInicial;
            this.DataSorteio = dataSorteio;
            this.QtdeCotas = qtdeCotas;
            this.Status = status;
        }

        public int Numero { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataSorteio { get; private set; }
        public int QtdeCotas { get; private set; }
        public int Status { get; set; } // Criar Enum com Description
    }
}
