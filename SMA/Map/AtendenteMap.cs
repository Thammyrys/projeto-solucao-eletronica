using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMA.Contracts.Data;

namespace SMA.Map
{
    public class AtendenteMap : IEntityTypeConfiguration<Atendente>
    {
        public void Configure(EntityTypeBuilder<Atendente> builder)
        {
            builder.ToTable("tb_atendente"); //NOME TABELA

            builder.HasKey(x => x.Id); // CHAVE PRIMARIA

            builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName("nome").IsRequired().HasMaxLength(100);
            builder.Property(x => x.CPF).HasColumnName("cpf").IsRequired();
            builder.Property(x => x.Endereco).HasColumnName("endereco").IsRequired().HasMaxLength(200);
            builder.Property(x => x.Telefone).HasColumnName("telefone").IsRequired();

            builder.HasMany(x => x.Orcamento);
            builder.HasMany(x => x.OrdemServico);
        }
    }
}
