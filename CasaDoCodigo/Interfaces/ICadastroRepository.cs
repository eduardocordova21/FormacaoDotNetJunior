using CasaDoCodigo.Models;
using System.Threading.Tasks;

namespace CasaDoCodigo.Interfaces
{
    public interface ICadastroRepository
    {
        Task<Cadastro> Update(int cadastroId, Cadastro novoCadastro);
    }
}