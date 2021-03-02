# OnlinePremios

##### Projeto Online Prêmios | Visual Studio, Asp.Net Core 3.1, Angular 11

> TaskList

-[ ] Criar entidades
[Criar Entidade para Cota]
 public class Cota : EntityBase
    {
        protected Cota(int numero, int status)
        {
            this.Numero = numero;
            this.Status = status;
        }

        public int Numero { get; private set; }
        public int Status { get; set; } // Criar Enum com Description
    }
 [Criar Enum de Status da Cota]
 namespace OnlinePremios.Domain.Enums
{
    public enum CotaStatus
    {
        Disponível = 1,
        Indisponível,
        Reservada
    }
}



[Criar a Entidade Pessoa]
public class Pessoa: EntityBase
    {
        protected Pessoa(Guid pessoaId, DateTime dataNascimento, string email, string telefone, string cpf, int status)
        {

            // Todo: Validar id != null, dataValida e qtde > 0;

            this.PessoaId = pessoaId;
            this.DataNascimento = dataNascimento;
            this.Email = email;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.Status = status;
        }

        public Guid PessoaId { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }
        public int Status { get; set; } // Todo: Transformar em Enum e usar Description
    }
    
[criar enum para Status da Pessoas
namespace OnlinePremios.Domain.Enums
{
    public enum PessoaStatus
    {
        Ativa = 1,
        Inativo,
        Pagante
    }
}
 


[e a bateria do meu NOT acabou]
