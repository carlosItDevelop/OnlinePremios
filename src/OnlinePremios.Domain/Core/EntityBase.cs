using System;

namespace OnlinePremios.Domain.Core
{
    public abstract class EntityBase
    {
        /// <summary>
        /// Entidade básica,de onde todos os models devem herdar.
        /// </summary>
        protected EntityBase()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        //    // Pra eu por este dado aqui eu preciso por no mapeamento de Paciente para PacienteViewModel;
        //    //public DateTime DataCadastro { get; set; } = DateTime.Now;

        public override bool Equals(object obj)
        {
            var compareTo = obj as EntityBase;
            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            // Todo: Sugerido pelo ReSharp sobre a abordagem acima:
            // Todo: Maneira mais inteligente de fazer, mas deixar eu analizar um pouco mais!
            //return !ReferenceEquals(null, compareTo) && Id.Equals(compareTo.Id);

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);

        }

        public static bool operator !=(EntityBase a, EntityBase b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 13) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        // Todo: Vou dar um Override no metodo Equals, que é um método que toda classe possui.
        // Todo: Por que? Porque a forma de comparar um objeto com outro é muito relativa. Lembrando que uma entidade possui identidade. Portanto para uma entidade ser igual a outra ela precisa ser do mesmo tipo e possuir o mesmo Id.



        // Todo: O campo DataCadastro deve ser incluído automaticamente, mas não deve ser alterado. Este processo será implementado no contexto da aplicação.
    }
}