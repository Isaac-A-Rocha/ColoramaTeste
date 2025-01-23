using Colorama.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colorama.Domain.Configurations;

public class ClientesConfiguration : IEntityTypeConfiguration<Clientes>
{
    public void Configure(EntityTypeBuilder<Clientes> builder)
    {
        builder
            .Property(c => c.Nome)
            .HasMaxLength(150)
            .IsRequired();
        
        builder
            .Property(c => c.Cpf)
            .HasMaxLength(11)
            .IsRequired();
        
        builder
            .Property(c => c.Email)
            .HasMaxLength(150)
            .IsRequired();
        
        builder
            .Property(c => c.Senha)
            .HasMaxLength(10)
            .IsRequired();
        
        builder
            .Property(c => c.Telefone)
            .HasMaxLength(11)
            .IsRequired();
      
        builder
            .Property(c => c.DataDeNascimento)
            .IsRequired();
      
        builder
            .Property(c => c.Endereço)
            .HasMaxLength(30)
            .IsRequired();
       
        builder
            .Property(c => c.Complemento)
            .HasMaxLength(15)
            .IsRequired();
        
        builder
            .Property(c => c.Cep)
            .HasMaxLength(8)
            .IsRequired();
      
        builder
            .Property(c => c.Cidade)
            .HasMaxLength(50)
            .IsRequired();
      
        builder
            .Property(c => c.Estado)
            .HasMaxLength(50)
            .IsRequired();
        
        builder
            .Property(c => c.AtualizadoEm)
            .IsRequired();
        
        builder
            .Property(c => c.CriadoEm)
            .IsRequired();
    }
}