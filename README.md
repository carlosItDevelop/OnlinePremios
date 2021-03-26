## OnlinePremios

##### Projeto Online Prêmios | Visual Studio, Asp.Net Core 3.1

> Migrar para .NET5

> TaskList Processos:

- [ ] _**USUÁRIOS / CLIENTES:**_
  - [ ] Cadastro de Usuários;
    - [ ] Definir Papeis dos Usuários;
- [ ] _**SORTEIO:**_
  - [ ] Criar um Sorteio;
    - [ ] Adicionar Vendedor;
    - [ ] Definir Data inicial e Data do Sorteio;
    - [ ] Adicionar Fotos do Sorteio;
    - [ ] Definir a quantidade de Cotas;
    - [ ] Gerar Cotas em massa pela quantidade informada, sempre iniciar do 0;
- [ ] _**COMPRA:**_
  - [ ] Iniciar uma Compra;
      - [ ] Adicionar Cliente;
      - [ ] Associar Sorteio(s);
      - [ ] Adicionar CompraItems para a Compra / Cliente
      - [ ] Criar Checkout;
      - [ ] Alterações de Status = Pendente de pagamento;
      - [ ] Alteração dos Status da Cota = Reservada
      - [ ] Finalizar Compra;
      - [ ] Confirma Pagamento da compra;
      - [ ] Alterações de Status = Confirmada;


_**MUDANÇA QUE FIZ NA PARTE BAIXA**_
- [X] Mudei o nome de CotaVendida para CompraItem
  - [ ] Acho que ja esta todos os codigos prontos;
      - [ ] apenas analizar;

---

> Prof. Preciso que faça o mapeamento da cota para o sorteio

---

_**IMPORTANTE**_
- [ ] Fazer mapeamento de cota para o sorteio, retirando o mapeamento de compra
- [ ] Quando cadastrar um sorteio ja fazer o cadastro das cotas em massa
    - [ ] Número sequencial iniciado do 0 ate a quantidade informada
    - [ ] Valor da cota
    - [ ] Status = Disponivel

---

> Quando fizer esse mapeamento eu ja vou cadastrar o primeiro sorteio
> para apresentar as cotas já cadastradas e vendendo

---

---

> Vamos trabalhar com carrinho de compra para adicionar as cotas
> fazer no codigo HTML o o jQuery para adicionar e remover do carrinho o CompraItem
> Se no carrinho estiver aquele ID Remove se não Adiciona

---

---

> Vou usar esse CSharp para esplicar os codigo que eu fiz

---
```CSharp

namespace OnlinePremios.Domain.Entities
{
    public class CompraItem : EntityBase
    {
        public CompraItem(int numero, decimal valor)
        {
            this.Numero = numero;
            this.Valor = valor;
        }

        // to EF
        public CompraItem() { }

        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public Guid CompraId { get; set; }

        public virtual Compra Compra { get; set; }

    }
}

namespace OnlinePremios.Data.Mapping
{
    public class CompraItemMap : IEntityTypeConfiguration<CompraItem>
    {
        public void Configure(EntityTypeBuilder<CompraItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Numero).IsRequired().HasColumnName("Numero");
            builder.Property(x => x.Valor).IsRequired().HasColumnName("Valor");

            builder.ToTable("CompraItem");

            // 1:N Compras : CompraItem
            builder.HasOne(x => x.Compra)
                .WithMany(x => x.CompraItems)
                .HasForeignKey(x => x.CompraId);
        }
    }
}



namespace OnlinePremios.Repository
{
    public class CompraRepository : RepositoryGeneric<Compra, Guid>, ICompraRepository
    {

        private readonly OnlinePremiosContext _ctx;

        public CompraRepository(OnlinePremiosContext context) : base(context)
        {
            this._ctx = context;
        }

        public async Task<IEnumerable<Compra>> ObterTodasAsComprasComSuasCotas()
        {
            return await _ctx.Compra.AsNoTracking().Include(f => f.Cotas).ToListAsync();
        }

        public async Task<IEnumerable<Compra>> ObterTodasAsComprasDeUmCliente(Guid clienteId)
        {
            return await _ctx.Compra.AsNoTracking().Where(x => x.ClienteId == clienteId).ToListAsync();
        }

        public async Task<Compra> ObterUmaCompra(Guid id)
        {
            return await _ctx.Compra.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}


namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface ICompraItemRepository : IGenericRepository<CompraItem, Guid>
    {

        Task<IEnumerable<CompraItem>> ObterTodasAsCompraItemsDeUmaCompra(Guid compraId);
        Task<IEnumerable<CompraItem>> ObterTodasAsCompraItemsComSuasCompras();
        Task<CompraItem> ObterUmaCompraItemComSuaCompra(Guid id);
    }

}


namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface ICompraItemService : IDisposable
    {
        Task Adicionar(CompraItem compraItem);
        Task Atualizar(CompraItem compraItem);
        Task Remover(Guid id);
    }
}


```