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

            builder.Property(x => x.ImgURL).IsRequired().HasColumnName("ImgURL").HasMaxLength(2000);
            builder.Property(x => x.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(400);
            builder.Property(x => x.Descricao).IsRequired().HasColumnName("Descricao").HasMaxLength(400);
            builder.Property(x => x.GaleriaId).IsRequired().HasColumnName("GaleriaId");

            // N:1 Galeria
            builder.HasOne(x => x.Galeria)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.GaleriaId);

            builder.ToTable("Produto");

        }
    }
}
