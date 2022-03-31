using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMA.Map
{
    public class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("tb_ordemServico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ClienteId).HasColumnName("clienteId").IsRequired();
            builder.Property(x => x.AparelhoId).HasColumnName("aparelhoId").IsRequired();
            builder.Property(x => x.DataGarantia).HasColumnName("dataGarantia").IsRequired().HasMaxLength(100);

            builder.HasOne(OS => OS.Cliente).WithMany(C => C.OrdemServico).HasForeignKey(x => x.ClienteId);
            builder.HasOne(OS => OS.Aparelho).WithMany().HasForeignKey(x => x.AparelhoId);
        }
    }
}
