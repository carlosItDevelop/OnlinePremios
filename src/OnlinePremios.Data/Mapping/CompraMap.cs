using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;
using System;

namespace OnlinePremios.Data.Mapping
{
    public class CompraMap : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            throw new NotImplementedException();
        }
    }
}
