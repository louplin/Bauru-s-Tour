using System.Text.Json;
namespace BaurusTour.Services
{

    public class Favoritos
    {
        private List<string> favoritos = new List<string>();

        private readonly string caminho = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Bauru's Tour",
            "favoritos.json");

   
        private void Carregar()
        {
            
            if (!File.Exists(caminho))
                {
                return;
                }
            try
            {
                string json = File.ReadAllText(caminho);
                favoritos = JsonSerializer.Deserialize<List<string>>(json);
            }
            catch (JsonException)
            {
                // Se o arquivo json é estragado a lista começa vazia.
            }
        }
        
        private void salvar()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(caminho));
            string json = JsonSerializer.Serialize(favoritos);
            File.WriteAllText(caminho, json);
        }
        public bool EhFavorito (String nome)
        {
         bool Favoritado = favoritos.Contains(nome);
            return Favoritado;
        }

        public bool Alternar(string nome)
        {
            if (EhFavorito(nome))
            {
                favoritos.Remove(nome);
                salvar();
                return false;
            }
            else
            {
                favoritos.Add(nome);
                salvar();
                return true;
            }
            
        } 
        public Favoritos()
        {
            Carregar();
        }
    }
   
}
