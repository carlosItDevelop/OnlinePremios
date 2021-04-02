using OnlinePremios.Mvc.Models;
using System.Collections.Generic;

namespace LanchesMac.ViewModels
{
    // Todo: Trocar Lanche por CotaItem (e depois refatorar de CotaItem para CotaItens)

    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
