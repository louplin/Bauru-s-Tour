using System.Text.Json;
using BauruTuor.Models;

namespace BauruTuor.Data
{
    public class PontoTuristicoRepository
    {
        private readonly string _caminhoArquivo;

        public PontoTuristicoRepository(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        public List<PontoTuristico> ObterTodos()
        {
            if (!File.Exists(_caminhoArquivo))
                return new List<PontoTuristico>();

            string json = File.ReadAllText(_caminhoArquivo);

            var opcoes = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<PontoTuristico>>(json, opcoes)
                   ?? new List<PontoTuristico>();
        }
    }
}
