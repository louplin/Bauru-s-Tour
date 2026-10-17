using BauruTuor.Data;
using BauruTuor.Models;

namespace BauruTuor.Services
{
    public class PontoTuristicoService
    {
        private readonly List<PontoTuristico> _pontos;

        public PontoTuristicoService(PontoTuristicoRepository repositorio)
        {
            _pontos = repositorio.ObterTodos();
        }

        public List<PontoTuristico> ListarTodos()
        {
            return _pontos;
        }

        public PontoTuristico? BuscarPorId(int id)
        {
            return _pontos.FirstOrDefault(p => p.Id == id);
        }

        public List<PontoTuristico> BuscarPorNome(string texto)
        {
            return _pontos
                .Where(p => p.Nome.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<PontoTuristico> FiltrarPorCategoria(string categoria)
        {
            return _pontos
                .Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<string> ListarCategorias()
        {
            return _pontos
                .Select(p => p.Categoria)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }
    }
}