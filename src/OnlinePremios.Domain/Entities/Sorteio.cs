using OnlinePremios.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePremios.Domain.Entities
{
    public class Sorteio : EntityBase
    {
        protected Sorteio(int numero, DateTime dataInicial, DateTime dataSorteio, int qtdeCotas)
        {
            this.Numero = numero;
            this.DataInicial = dataInicial;
            this.DataSorteio = dataSorteio;
            this.QtdeCotas = qtdeCotas;
        }

        public int Numero { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataSorteio { get; private set; }
        public int QtdeCotas { get; private set; }

    }
}
