namespace BauruThur.Models
{
    public class PontoTuristico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string LinkMaps { get; set; } = string.Empty;
    }
}
