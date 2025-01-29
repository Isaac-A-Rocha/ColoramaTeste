using Colorama.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colorama.Domain.Configurations
{
    public class ProdutosConfigurations : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder
                .Property(p => p.Nome)
                .HasMaxLength(100)  
                .IsRequired();  

            builder
                .Property(p => p.Descricao)
                .HasMaxLength(200)  
                .IsRequired();  

            builder
                .Property(p => p.Preco)
                .HasPrecision(8, 2)  
                .IsRequired();  

            builder
                .Property(p => p.QuantidadeemEstoque)
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
            .Property(t => t.AtualizadoEm)
            .IsRequired();

        builder
            .Property(t => t.CriadoEm)
            .IsRequired();
        }
    }
}
