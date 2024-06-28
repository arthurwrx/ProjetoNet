using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<DiaColeta> DiaColeta { get; set; }
        public virtual DbSet<ColetaModel> Coletas { get; set; }
        public virtual DbSet<Morador> Moradores { get; set; }
        public virtual DbSet<Notificacao> Notificacoes { get; set; }
        public virtual DbSet<TipoResiduos> Residuos { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521)))(CONNECT_DATA=(SID=orcl)));Persist Security Info=True;User ID=98398;Password=070105;Pooling=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da entidade DiaColeta
            modelBuilder.Entity<DiaColeta>(entity =>
            {
                entity.ToTable("TB_DIA_COLETA");
                entity.HasKey(e => e.DiaDeColetaId);
            });

            modelBuilder.Entity<ColetaModel>(entity =>
            {
                entity.ToTable("TB_COLETA_MODEL");
                entity.HasKey(e => e.DiaColetaId);
            });

            // Configuração da entidade Morador
            modelBuilder.Entity<Morador>(entity =>
            {
                entity.ToTable("TB_MORADOR");
                entity.HasKey(e => e.MoradorId);
            });

            // Configuração da entidade Notificacao
            modelBuilder.Entity<Notificacao>(entity =>
            {
                entity.ToTable("TB_NOTIFICACAO");
                entity.HasKey(e => e.NotificacaoId);

                entity.HasOne(e => e.Morador)
                    .WithMany()
                    .HasForeignKey(e => e.MoradorId)
                    .IsRequired();

                entity.HasOne(e => e.DiaColeta)
                    .WithMany()
                    .HasForeignKey(e => e.DiaColetaId)
                    .IsRequired();

                entity.HasOne(e => e.TipoResiduos)
                    .WithMany()
                    .HasForeignKey(e => e.TipoResiduosId)
                    .IsRequired();
            });

            // Configuração da entidade TipoResiduos
            modelBuilder.Entity<TipoResiduos>(entity =>
            {
                entity.ToTable("TB_TIPO_RESIDUOS");
                entity.HasKey(e => e.TipoResiduosId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
