## OnlinePremios

##### Projeto Online Prêmios | Visual Studio, Asp.Net Core 3.1

> Migrar para .NET5

> TaskList Processos:

- [ ] _**USUÁRIOS / CLIENTES:**_
  - [ ] Cadastro de Usuários;
    - [ ] Definir Papeis dos Usuários;
- [ ] _**SORTEIO:**_
  - [ ] Criar um Sorteio;
    - [ ] Definir Data inicial e Data do Sorteio;
    - [ ] Adicionar Fotos do Sorteio;
    - [ ] Adicionar Produtos na Galeria do Sorteio;
- [ ] _**COMPRA:**_
  - [ ] Iniciar uma Compra;
      - [ ] Adicionar Cliente;
      - [ ] Associar Sorteio(s);
      - [ ] Criar Checkout;
      - [ ] Alterações de Status;
      - [ ] Finalizar Compra;
- [ ] _**COTAS**_
    - [ ] 


---

> Prof. Preciso que faça o mapeamento da cota para o sorteio

---
#### Precisa mudar o Mapeamento de Cota 
```CSharp
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Data.Mapping
{
    public class CotaMap : IEntityTypeConfiguration<Cota>
    {
        public void Configure(EntityTypeBuilder<Cota> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Numero).IsRequired().HasColumnName("Numero");
            builder.Property(x => x.StatusCota).IsRequired().HasColumnName("StatusCota");
            builder.Property(x => x.Valor).IsRequired().HasColumnName("Valor");

            builder.ToTable("Cota");

            // 1:N Compras : Cota
            builder.HasOne(x => x.Compra)
                .WithMany(x => x.Cotas)
                .HasForeignKey(x => x.CompraId);
        }
    }
}

```