namespace WebApplication1.Models
{   

    public class ColetaModel
    {
        public int DiaColetaId { get; set; }
        public DateTime DataHora { get; set; }
        public string ?Bairro { get; set; }
        public string ?TipoColeta { get; set; }
    }
}
