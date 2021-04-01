using OnlinePremios.Repositories.Interfaces;
using OnlinePremios.Mvc.Data;
using OnlinePremios.Mvc.Models;
using System.Collections.Generic;

namespace OnlinePremios.Repositories
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
