using Colorama.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Colorama.Domain.Configurations;
{

    public class TintasConfigurations : IEntityTypeConfiguration<Tintas>
    {
        public void Configure(EntityTypeBuilder<Tintas> builder)
        {
            builder
                .Property(t => t.TipoTinta)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(t => t.cor)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(t => t.Base)
                .IsRequired();

            builder
                .Property(t => t.DataDeValidade)
                .IsRequired();

            builder
                .Property(t => t.AtualizadoEm)
                .IsRequired();

            builder
                .Property(t => t.CriadoEm)
                .IsRequired();
        }
    }
}
