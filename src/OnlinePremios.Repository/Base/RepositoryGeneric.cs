using Microsoft.EntityFrameworkCore;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePremios.Repository.Base
{
    public abstract class RepositoryGeneric<TEntity, TKey> : IDomainGenericRepository<TEntity, TKey>
        where TEntity : EntityBase, new()
    {
        protected OnlinePremiosContext _context;

        // Precisa receber o contexto, pois como uma classe 
        // abstrata não pode ser instanciada, apenas herdada.
        protected RepositoryGeneric(OnlinePremiosContext ctx) 
        {
            this._context = ctx;
        }

        public async Task<TEntity> SelecionarPorId(TKey id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> SelecionarTodos(Expression<Func<TEntity, bool>> expressaowhere = null)
        {
            if (expressaowhere == null)
            {
                return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            return await _context.Set<TEntity>().AsNoTracking().Where(expressaowhere).ToListAsync();
        }

        public virtual async Task Atualizar(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await Salvar();
        }


        //public virtual async Task Excluir(TEntity obj)
        //{
        //    _context.Entry(obj).State = EntityState.Deleted;
        //    await Salvar();
        //}

        public virtual async Task ExcluirPorId(TKey id)
        {
            //TEntity obj = await SelecionarPorId(id);
            //await Excluir(obj);

            _context.Set<TEntity>().Remove(new TEntity { Id = Guid.Parse(id.ToString()) });
            await Salvar();
        }
        public async Task Inserir(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            await Salvar();
        }

        public void Dispose()
        {
            _context?.DisposeAsync();
        }

        public virtual async Task<int> Salvar()
        {
            return await _context.SaveChangesAsync();
        }



    }
}
