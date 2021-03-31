using OnlinePremio.Mvc.Models;
using System.Collections.Generic;

namespace LanchesMac.ViewModels
{
    // Todo: Trocar Lanche por CompraItem (e depois refatorar de CompraItem para CotaItens)

    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
