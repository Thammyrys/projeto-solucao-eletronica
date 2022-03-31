using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMA.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SMA.Map

{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>

    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("tb_cliente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.NomeCliente).HasColumnName("nomeCliente").IsRequired().HasMaxLength(100);
            builder.Property(x => x.TelefoneCliente).HasColumnName("telefoneCliente").IsRequired();
            builder.Property(x => x.CepCliente).HasColumnName("cepCliente").IsRequired();
            builder.Property(x => x.EnderecoCliente).HasColumnName("enderecoCliente").IsRequired().HasMaxLength(200);

        }
    }
}
