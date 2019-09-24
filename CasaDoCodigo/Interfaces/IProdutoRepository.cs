using CasaDoCodigo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasaDoCodigo.Interfaces
{
    public interface IProdutoRepository
    {
        IList<Produto> GetProdutos();

        Task SaveProdutos(List<Livro> livros);
    }
}