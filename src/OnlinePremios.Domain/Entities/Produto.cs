using OnlinePremios.Domain.Core;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto()
        {

        }

        public string ImgURL { get; set; }
        // Todo: file img (vou pensar se gravo no banco ou no disco;
        public string FileNome { get; set; }
        public Guid GaleriaId { get; set; }
        public virtual Galeria Galeria { get; set; }

    }
}
