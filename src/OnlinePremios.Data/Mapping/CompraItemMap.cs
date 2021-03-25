using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class CompraItemMap : IEntityTypeConfiguration<CompraItem>
    {
        public void Configure(EntityTypeBuilder<CompraItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Numero).IsRequired().HasColumnName("Numero");
            builder.Property(x => x.Valor).IsRequired().HasColumnName("Valor");

            builder.ToTable("CompraItem");

            // 1:N Compras : CompraItem
            builder.HasOne(x => x.Compra)
                .WithMany(x => x.CompraItems)
                .HasForeignKey(x => x.CompraId);
        }
    }
}
