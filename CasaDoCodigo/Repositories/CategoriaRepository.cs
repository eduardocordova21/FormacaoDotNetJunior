using CasaDoCodigo.Context;
using CasaDoCodigo.Interfaces;
using CasaDoCodigo.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public async Task<Categoria> AddCategoria(string nomeCategoria)
        {
            var categoriaDB = dbSet.Where(c => c.Nome == nomeCategoria).SingleOrDefault();

            if(categoriaDB == null)
            {
                var novaCategoria = new Categoria()
                {
                    Nome = nomeCategoria
                };

                categoriaDB = dbSet.Add(novaCategoria).Entity;
            }

            await contexto.SaveChangesAsync();
            return categoriaDB;
        } 
    }
}