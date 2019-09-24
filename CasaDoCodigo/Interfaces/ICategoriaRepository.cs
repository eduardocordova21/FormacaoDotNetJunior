using CasaDoCodigo.Models;
using System.Threading.Tasks;

namespace CasaDoCodigo.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<Categoria> AddCategoria(string nomeCategoria);
    }
}