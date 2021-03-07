using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public Cliente(string nome, string documento, string email, TipoPessoa tipoPessoa)
        {
            // Validar
            this.Nome = nome;
            this.Documento = documento;
            this.TipoPessoa = TipoPessoa;
            this.Email = email;
            this.StatusCliente = StatusCliente.Ativo;
        }

        // to EF
        public Cliente() { }

        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public TipoPessoa TipoPessoa { get; set; }

        public string Email { get; private set; }
        public StatusCliente StatusCliente { get; set; }
       
        public virtual IEnumerable<Compra> Compras { get; set; }

    }
}
