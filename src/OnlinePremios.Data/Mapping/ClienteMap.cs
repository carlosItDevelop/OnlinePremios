using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)").HasColumnName("Nome");

            // Todo: Fazer o relacionamento correto para Objeto de Valor
            builder.Property(x => x.Cpf).HasMaxLength(11).IsFixedLength(true).HasColumnName("Cpf").IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).HasColumnName("Email").IsRequired();

            builder.Property(x => x.StatusCliente).HasColumnName("StatusCliente").IsRequired();
            builder.ToTable("Cliente");

            // Todo: Relacionamento

        }
    }
}
