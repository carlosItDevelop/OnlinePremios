using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities.bcRevendedor;

namespace OnlinePremios.Data.Mapping
{
    public class RevendedorMap : IEntityTypeConfiguration<Revendedor>
    {
        public void Configure(EntityTypeBuilder<Revendedor> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //builder.Property(p => p.Documento)
            //    .IsRequired()
            //    .HasColumnType("varchar(14)");

            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Revendedor);

            //// 1 : N => Fornecedor : Produtos
            //builder.HasMany(f => f.Produtos)
            //    .WithOne(p => p.Fornecedor)
            //    .HasForeignKey(p => p.FornecedorId);

            builder.ToTable("Revendedor");
        }
    }
}
