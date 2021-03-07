using Microsoft.EntityFrameworkCore;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePremios.Repository
{
    public class ProdutoRepository : RepositoryGeneric<Produto, Guid>, IProdutoRepository
    {
        private readonly OnlinePremiosContext _ctx;
        public ProdutoRepository(OnlinePremiosContext context) : base(context) 
        {
            this._ctx = context;
        }

        public async Task<IEnumerable<Produto>> ObterTodosOsProdutosComSuasGalerias()
        {
                return await _ctx.Produto.AsNoTracking().Include(f => f.Galeria)
                    .OrderBy(p => p.DataCadastro).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterTodosOsProdutosDeUmaGaleria(Guid galeriaId)
        {
                return await SelecionarTodos(p => p.Id == galeriaId);
        }


        public async Task<Produto> ObterUmProdutoComSuaGaleria(Guid id)
        {
                return await _ctx.Produto.AsNoTracking().Include(f => f.Galeria)
                    .FirstOrDefaultAsync(p => p.Id == id);
        }

    }
}
