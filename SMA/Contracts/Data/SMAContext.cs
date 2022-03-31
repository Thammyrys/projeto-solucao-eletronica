using Microsoft.EntityFrameworkCore;
using SMA.Contracts.Data;

namespace SMA.Data
{
    public class SMAContext : DbContext
    {
        public SMAContext(DbContextOptions<SMAContext> options) : base(options) { }

        public DbSet<Aparelho> Aparelhos { get; set; }
        public DbSet<Atendente> Atendentes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<OrdemServico> OrdemServicos { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
    }
}
