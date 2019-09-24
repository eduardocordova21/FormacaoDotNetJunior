using CasaDoCodigo.Models;

namespace CasaDoCodigo.Interfaces
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);

        void RemoveItemPedido(int itemPedidoId);
    }
}