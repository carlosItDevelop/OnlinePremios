using OnlinePremios.Domain.Core;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto(string nome, string imgUrl, string descricao)
        {
            this.ImgURL = imgUrl;
            this.Descricao = descricao;
            this.Nome = nome;
        }

        // to EF
        public Produto() { }
        public string Nome { get; private set; }

        public string Descricao { get; set; }

        public string ImgURL { get; private set; }


    }
}
