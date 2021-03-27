using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlinePremios.Domain.Entities;

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

    }
}
