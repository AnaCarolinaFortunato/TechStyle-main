using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStyle.Dominio.Modelo;

namespace TechStyle.Dados.Map
{
    public class SegmentoMap : IEntityTypeConfiguration<Segmento>
    {
        public void Configure(EntityTypeBuilder<Segmento> builder)
        {
            builder.ToTable("Segmento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Categoria)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.SubCategoria)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasMany<Produto>(p => p.Produtos)
                .WithOne(s => s.Segmento)
                .HasForeignKey(i => i.IdSegmento);
        }
    }
}
