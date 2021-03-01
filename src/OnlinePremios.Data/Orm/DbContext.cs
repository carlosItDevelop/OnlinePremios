using Microsoft.EntityFrameworkCore;

namespace OnlinePremios.Data.Orm
{

    public class OnlinePremiosContext : DbContext
    {
        public OnlinePremiosContext(DbContextOptions<OnlinePremiosContext> options)
            : base(options)
        {
        }
    }
}
