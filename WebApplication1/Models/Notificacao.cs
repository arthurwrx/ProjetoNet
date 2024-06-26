namespace WebApplication1.Models
{
    public class Notificacao
    {
        public int NotificacaoId { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
        public string Status { get; set; }
        public int MoradorId { get; set; }
        public Morador Morador { get; set; }
        public int DiaColetaId { get; set; }
        public DiaColeta DiaColeta { get; set; }
        public int TipoResiduosId { get; set; }
        public TipoResiduos TipoResiduos { get; set; }
    }
}
