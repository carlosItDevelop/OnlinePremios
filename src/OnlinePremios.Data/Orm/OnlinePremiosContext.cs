using Microsoft.EntityFrameworkCore;
using OnlinePremios.Domain.Entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlinePremios.Data.Orm
{

    public class OnlinePremiosContext : DbContext
    {
        public OnlinePremiosContext(DbContextOptions<OnlinePremiosContext> options)
            : base(options)
        {
        }

        public DbSet<Compra> Compra { get; set; }
        public DbSet<Sorteio> Sorteio { get; set; }
        public DbSet<Cota> Cota { get; set; }
        public DbSet<CompraItem> CompraItem { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // onde não tiver setado varchar e a propriedade for 
            // do tipo string fica valendo varchar(100)

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(90)");  // Ok: Faltava instalar o Microsoft.EntityFrameworkCore.Relational
                //property.Relational().ColumnType = "varchar(100)"; Até ANC2.x
            }

            // Posso pegar arquivo por arquivo ou usar a implementação Impl033;
            //modelBuilder.ApplyConfiguration(new PacienteMap());
            // Impl033: Busca os Mapppings de uma vez só
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OnlinePremiosContext).Assembly);

            // Evitar a Deleção em cascata nos meus relacionamentos
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);


        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
