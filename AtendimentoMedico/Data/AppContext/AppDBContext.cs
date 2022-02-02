using Microsoft.EntityFrameworkCore;

namespace AtendimentoMedico.Data.AppContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Medico> Medico { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder
                .Entity<Atendimento>()
                .ToTable("atendimento");

            modelBuilder
                .Entity<Medico>()
                .ToTable("medico");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer("Server=localhost,1473;Database=db_Atendimento;" +
                                        "User Id=sa;Password=1Secure*Password1;");
        }
    }
}