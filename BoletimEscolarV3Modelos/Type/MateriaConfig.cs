using BoletimEscolarVersao3.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoletimEscolarVersão3Modelos.Type
{
    public class MateriasConfig : IEntityTypeConfiguration<Materia>
    {

        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Descrição).IsRequired();
            builder.Property(q => q.DataCadastro).IsRequired();
            builder.Property(q => q.Situação).IsRequired();

        }
    }
}
