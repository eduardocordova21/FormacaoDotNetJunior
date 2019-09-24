using CasaDoCodigo.Models;
using System.Threading.Tasks;

namespace CasaDoCodigo.Interfaces
{
    public interface IPedidoRepository
    {
        Task AddItem(string codigo);

        Task<Pedido> GetPedido();

        Task<Pedido> UpdateCadastro(Cadastro cadastro);

        Task<UpdateQuantidadeResponse> UpdateQuantidade(ItemPedido itemPedido);
    }
}