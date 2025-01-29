using Colorama.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colorama.Domain.Configurations
{
    public class MaterialDePinturaConfiguration : IEntityTypeConfiguration<MaterialDePintura>
    {
        public void Configure(EntityTypeBuilder<MaterialDePintura> builder)
        {
            builder
                .Property(p => p.TipoMaterial)
                .HasMaxLength(50)
                .IsRequired();  

            builder
                .Property(p => p.Tamanho)
                .HasMaxLength(200)  
                .IsRequired();  

            builder
                .Property(p => p.Preco)
                .HasPrecision(8, 2)  
                .IsRequired();  

            builder
                .Property(p => p.QuantidadePorPacote)
                .IsRequired();  

            builder
                .Property(p => p.Categoria)
                .IsRequired();  

            builder
                .Property(p => p.Fabricante)
                .HasMaxLength(100);  

            builder
                .Property(p => p.CodigoProduto)
                .HasMaxLength(50);  

            builder
                .Property(p => p.DataDeValidade)
                .IsRequired(false);  

            builder
                .Property(p => p.AtualizadoEm)
                .IsRequired();

            builder
                .Property(p => p.CriadoEm)
                .IsRequired();
        }
    }
}
