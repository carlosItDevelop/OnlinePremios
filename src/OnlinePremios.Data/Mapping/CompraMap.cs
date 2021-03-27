using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class CompraMap : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataCompra)
                .HasColumnName("DataCompra").IsRequired();
            builder.Property(x => x.ClienteId).IsRequired().HasColumnName("ClienteId");
            builder.Property(x => x.StatusCompra).IsRequired().HasColumnName("StatusCompra");
            builder.Property(x => x.QtdeCotas).HasColumnName("QtdeCotas").IsRequired();

            // Todo: Acertar, pois Cota não participa mais de Compra e sim de Sorteio. 
            // Todo: Em Compra, agora, temos CompraItem, que vai herdar de Cota.

            //// 1:N Cotas
            //builder.HasMany(x => x.Cotas)
            //    .WithOne(x => x.Compra)
            //    .HasForeignKey(x => x.CompraId);
        }
    }
}
