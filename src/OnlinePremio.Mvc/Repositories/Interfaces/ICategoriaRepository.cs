using OnlinePremio.Mvc.Models;
using System.Collections.Generic;

namespace OnlinePremio.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
