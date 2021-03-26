using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class SorteioMap : IEntityTypeConfiguration<Sorteio>
    {
        public void Configure(EntityTypeBuilder<Sorteio> builder)
        {

            builder.HasKey(x => x.Id);

            /*
             * Todo: Estudar este campo, pois tem um relacioanamento de 1:1 com Galeria 
             * e não está bom para o negócio, na minha visão!
             * 
                //public Guid GaleriaId { get; set; } // Todo: Avaliar este campo, pois tb tem em produto
                //public virtual Galeria Galeria { get; set; }             
            */

            builder.Property(x => x.Numero).IsRequired().HasColumnName("Numero");
            builder.Property(x => x.DataInicial).IsRequired().HasColumnName("DataInicial");
            builder.Property(x => x.DataSorteio).IsRequired().HasColumnName("DataSorteio");
            builder.Property(x => x.QtdeCotas).IsRequired().HasColumnName("QtdeCotas");
            builder.Property(x => x.StatusSorteio).IsRequired().HasColumnName("StatusSorteio");
            builder.Property(x => x.ValorCotas).IsRequired().HasColumnName("ValorCotas");


            // 1:N Sorteio : Cota
            builder.HasMany(c => c.Cota)
                .WithOne(s => s.Sorteio)
                .HasForeignKey(fk => fk.SorteioId);

        }
    }
}
