using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class CotaMap : IEntityTypeConfiguration<Cota>
    {
        public void Configure(EntityTypeBuilder<Cota> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Numero).IsRequired().HasColumnName("Numero");
            builder.Property(x => x.StatusCota).IsRequired().HasColumnName("StatusCota");
            builder.Property(x => x.Valor).IsRequired().HasColumnName("Valor");

            builder.ToTable("Cota");

            // 1:N Sorteio : Cota
            builder.HasOne(x => x.Sorteio)
                .WithMany(x => x.Cota)
                .HasForeignKey(x => x.SorteioId);
        }
    }
}
