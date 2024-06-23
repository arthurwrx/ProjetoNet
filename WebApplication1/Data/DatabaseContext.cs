using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<DiaColeta> DiaColeta { get; set; }
        public virtual DbSet<LogNotificacoes> LogNotificacoes { get; set; }
        public virtual DbSet<Morador> Morador { get; set; }
        public virtual DbSet<Notificacao> Notificacao { get; set; }
        public virtual DbSet<TipoResiduos> TipoResiduos { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DatabaseContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaColeta>(entity =>
            {
                entity.ToTable("TB_DIA_COLETA");
                entity.HasKey(e => e.DiaColetaId);
            });

            modelBuilder.Entity<LogNotificacoes>(entity =>
            {
                entity.ToTable("TB_LOG_NOTIFICACOES");
                entity.HasKey(e => e.LogId);
            });

            modelBuilder.Entity<Morador>(entity =>
            {
                entity.ToTable("TB_MORADOR");
                entity.HasKey(e => e.MoradorId);
            });

            modelBuilder.Entity<Notificacao>(entity =>
            {
                entity.ToTable("TB_NOTIFICACAO");
                entity.HasKey(e => e.NotificacaoId);
            });

            modelBuilder.Entity<TipoResiduos>(entity =>
            {
                entity.ToTable("TB_TIPO_RESIDUOS");
                entity.HasKey(e => e.TipoResiduosId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
