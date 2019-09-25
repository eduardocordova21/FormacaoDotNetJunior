using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.ViewModels
{
    public class BuscaViewModel
    {
        public BuscaViewModel(IList<Produto> itens)
        {
            this.Itens = itens;
        }

        public IList<Produto> Itens { get; set; }

        public string Pesquisa { get; set; }
    }
}