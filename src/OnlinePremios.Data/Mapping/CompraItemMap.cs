using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class CompraItemMap : IEntityTypeConfiguration<CotaItem>
    {
        public void Configure(EntityTypeBuilder<CotaItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Numero).IsRequired().HasColumnName("Numero");
            builder.Property(x => x.Valor).IsRequired().HasColumnName("Valor");

            builder.ToTable("CotaItem");

            // 1:N Compras : CotaItem
            builder.HasOne(x => x.Compra)
                .WithMany(x => x.CompraItens)
                .HasForeignKey(x => x.CompraId);
        }
    }
}
