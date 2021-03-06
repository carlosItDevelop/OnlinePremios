﻿using Microsoft.EntityFrameworkCore;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces;
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

        public Task<IEnumerable<Produto>> ObterTodosOsProdutosComSeusSorteios()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produto>> ObterTodosOsProdutosComSuasGalerias()
        {
                return await _ctx.Produto.AsNoTracking().Include(f => f.Galeria)
                    .OrderBy(p => p.DataCadastro).ToListAsync();
        }

        public Task<IEnumerable<Produto>> ObterTodosOsProdutosDeUmaGaleria(Guid galeriaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterTodosOsProdutosDeUmSorteio(Guid sorteioId)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> ObterUmProdutoComSeuSorteio(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> ObterUmProdutoComSuaGaleria(Guid id)
        {
            throw new NotImplementedException();
        }

        //public async Task<Produto> ObterProdutoFornecedor(Guid id)
        //{
        //    return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
        //        .FirstOrDefaultAsync(p => p.Id == id);
        //}

        //public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        //{
        //    return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
        //        .OrderBy(p => p.Nome).ToListAsync();
        //}

        //public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        //{
        //    return await Buscar(p => p.FornecedorId == fornecedorId);
        //}
    }
}
