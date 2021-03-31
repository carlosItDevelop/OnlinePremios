﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlinePremio.Mvc.Models;
using System.Linq;

namespace OnlinePremio.Mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OnlinePremios.Domain.Entities.Sorteio> Sorteio { get; set; }
        public DbSet<OnlinePremios.Domain.Entities.Cliente> Cliente { get; set; }
        public DbSet<OnlinePremios.Domain.Entities.Cota> Cota { get; set; }


        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// onde não tiver setado varchar e a propriedade for 
            //// do tipo string fica valendo varchar(100)

            //foreach (var property in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetProperties()
            //        .Where(p => p.ClrType == typeof(string))))
            //{
            //    property.SetColumnType("varchar(90)");  // Ok: Faltava instalar o Microsoft.EntityFrameworkCore.Relational
            //    //property.Relational().ColumnType = "varchar(100)"; Até ANC2.x
            //}

            // Posso pegar arquivo por arquivo ou usar a implementação Impl033;
            //modelBuilder.ApplyConfiguration(new PacienteMap());
            // Impl033: Busca os Mapppings de uma vez só
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            // Evitar a Deleção em cascata nos meus relacionamentos
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);


        }

        // Todo: this Overide SaveChangesAsync

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }

        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("DataCadastro").IsModified = false;
        //        }
        //    }

        //    return base.SaveChangesAsync(cancellationToken);
        //}


    }
}
