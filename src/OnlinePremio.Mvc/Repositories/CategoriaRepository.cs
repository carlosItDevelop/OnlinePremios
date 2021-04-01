using OnlinePremio.Repositories.Interfaces;
using OnlinePremio.Mvc.Data;
using OnlinePremio.Mvc.Models;
using System.Collections.Generic;

namespace OnlinePremio.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
