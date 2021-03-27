using OnlinePremios.Domain.Core;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Endereco : EntityBase
    {
        // EF
        public Endereco(){}

        /*
            Todo: Criar IService, Service, IRepository, Repository, Validation, Mapping, AutoMap, DI, (ViewModel)   
         */

        public Guid RevendedorId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        /* EF Relation */
        public Revendedor Revendedor { get; set; }


    }
}


