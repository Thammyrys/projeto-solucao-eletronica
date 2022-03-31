using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMA.Contracts.Data;

namespace SMA.Map
{
    public class TecnicoMap : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("tb_Tecnico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(100);
            builder.Property(x => x.CPF).HasColumnName("cpf").IsRequired();
            builder.Property(x => x.Endereco).HasColumnName("endereco").IsRequired().HasMaxLength(200);
            builder.Property(x => x.Telefone).HasColumnName("telefone").IsRequired();

            builder.HasMany(x => x.Aparelhos);
        }
    }
}
