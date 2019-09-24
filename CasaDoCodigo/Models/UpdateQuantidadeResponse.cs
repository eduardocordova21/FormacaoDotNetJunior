using CasaDoCodigo.ViewModels;

namespace CasaDoCodigo.Models
{
    public class UpdateQuantidadeResponse
    {
        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }

        public CarrinhoViewModel CarrinhoViewModel { get; }

        public ItemPedido ItemPedido { get; }
    }
}