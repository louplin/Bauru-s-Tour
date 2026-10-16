namespace BaurusTour.Services
{
    public class Favoritos
    {
        private List<string> favoritos = new List<string>();   
        
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
                return false;
            }
            else
            {
                favoritos.Add(nome);
                return true;
            }
            
        }
    }

}