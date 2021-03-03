﻿using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePremios.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public Cliente(string nome, string cpf, string email)
        {
            // Validar
            this.Nome = nome;
        }

        public string Nome { get; private set; }
        public CPF Cpf { get; private set; }
        public EMAIL Email { get; private set; }

        // Adicionar AdHocks para CPF e EMAIL;


    }
}