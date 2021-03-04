using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class GaleriaMap : IEntityTypeConfiguration<Galeria>
    {
        public void Configure(EntityTypeBuilder<Galeria> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.SorteioId).HasColumnName("SorteioId").IsRequired();

            // 1:1 Sorteio
            builder.HasOne(s => s.Sorteio)
                .WithOne(fk => fk.Galeria);

            // 1 : N => Produtos
            builder.HasMany(g => g.Produtos)
                .WithOne(g => g.Galeria)
                .HasForeignKey(fk => fk.GaleriaId);

            builder.ToTable("Galeria");

        }
    }
}
