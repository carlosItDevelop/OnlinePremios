﻿using OnlinePremios.Domain.Core;
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
            this.Cpf = cpf;
            this.Email = email;
            this.StatusCliente = StatusCliente.Ativo;
        }

        // to EF
        public Cliente() { }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public StatusCliente StatusCliente { get; set; }
       
        public virtual IEnumerable<Compra> Compras { get; set; }

    }
}
