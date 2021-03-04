using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public Cliente(string nome, string cpf, string email)
        {
            // Validar
            this.Nome = nome;
            this.StatusCliente = StatusCliente.Ativo;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public StatusCliente StatusCliente { get; set; }
       
        public virtual ICollection<Compra> Compras { get; set; }

    }
}
