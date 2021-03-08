using OnlinePremios.Domain.Core;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto(string imgUrl, string fileName, Guid galeriaId)
        {
            this.ImgURL = imgUrl;
            this.FileName = fileName;
            this.GaleriaId = galeriaId;
        }

        // to EF
        public Produto() { }

        public string ImgURL { get; private set; }

        public string FileName { get; private set; }
        public Guid GaleriaId { get; private set; }
        public virtual Galeria Galeria { get; set; }

    }
}
