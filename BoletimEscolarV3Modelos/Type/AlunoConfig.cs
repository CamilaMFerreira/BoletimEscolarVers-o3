using BoletimEscolarVersao3.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoletimEscolarVersão3Modelos.Type
{
    public class AlunoConfig : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {


            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nome).IsRequired().HasMaxLength(100);
            builder.Property(q => q.Sobrenome).IsRequired().HasMaxLength(100);
            builder.Property(q => q.Cpf).IsRequired().HasMaxLength(100);
            builder.Property(q => q.DataNascimento).IsRequired();
            builder.Property(q => q.Função).IsRequired().HasMaxLength(100); 

        }

    }
}
