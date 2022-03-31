using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMA.Data;

namespace SMA.Map
{
    public class AparelhoMap : IEntityTypeConfiguration<Aparelho>
    {
        public void Configure(EntityTypeBuilder<Aparelho> builder)
        {
            builder.ToTable("tb_aparelho");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Marca).HasColumnName("marca").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Modelo).HasColumnName("modelo").HasMaxLength(100).IsRequired();
            builder.Property(x => x.NumeroDeSerie).HasColumnName("numeroDeSerie").HasMaxLength(100).IsRequired();
            builder.Property(x => x.EstaNaGarantia).IsRequired();
            builder.Property(x => x.Status).HasColumnName("Status");
            builder.Property(x => x.DescricaoDoDefeito).HasColumnName("DescricaoDoDefeito").HasMaxLength(100).IsRequired();
            builder.Property(x => x.DataDeEntrada).HasColumnName("DataDeEntrada").HasColumnType("datetime");
            builder.Property(x => x.DataDeSaida).HasColumnName("DataDeSaida").HasColumnType("datetime");

        }
    }
}
