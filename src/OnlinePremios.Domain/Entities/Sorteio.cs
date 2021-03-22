using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Sorteio : EntityBase
    {
        protected Sorteio(int numero, DateTime dataInicial, 
            DateTime dataSorteio, int qtdeCotas)
        {
            this.Numero = numero;
            this.DataInicial = dataInicial;
            this.DataSorteio = dataSorteio;
            this.QtdeCotas = qtdeCotas;
            this.StatusSorteio = StatusSorteio.Ativo;
        }

        // to EF
        public Sorteio() { }

        public int Numero { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataSorteio { get; private set; }
        public int QtdeCotas { get; private set; }
        public StatusSorteio StatusSorteio { get; set; }

        public virtual IEnumerable<Cota> Cota { get; set; }

    }
}
