using OnlinePremios.Mvc.Models;
using System.Collections.Generic;

namespace OnlinePremios.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
