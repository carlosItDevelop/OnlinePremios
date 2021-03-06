﻿using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;

namespace OnlinePremios.Domain.Entities.bcRevendedor
{
    public class Revendedor : EntityBase
    {
        // To EF
        public Revendedor() {}

        public Revendedor(string nome, string cpf, string email, string rg, TipoPessoa tipoPessoa, StatusRevendedor status)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Rg = rg;
            this.TipoPessoa = tipoPessoa;
            this.StatusRevendedor = status;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Email { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }
        public StatusRevendedor StatusRevendedor { get; private set; }

        public Endereco Endereco { get; set; }

        /* EF Relations */
        //public IEnumerable<Sorteio> Sorteios { get; set; }



        /*
            Todo: Criar IService, Service, IRepository, Repository, Validation, (Mapping), AutoMap, DI, ViewModel
         */

    }
}
