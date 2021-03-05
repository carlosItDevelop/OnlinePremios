using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            /*
                public string ImgURL { get; set; }
                // Todo: file img (vou pensar se gravo no banco ou no disco;
                public string FileNome { get; set; }
                public Guid GaleriaId { get; set; }
                public virtual Galeria Galeria { get; set; }             
             */

            builder.ToTable("Produto");
        }
    }
}
