using BoletimEscolarVersao3.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoletimEscolarVersão3Modelos.Type
{
    public class CursoConfig : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nome).IsRequired().HasMaxLength(100);
            builder.Property(q => q.Situação).IsRequired();

        }
    }
}
