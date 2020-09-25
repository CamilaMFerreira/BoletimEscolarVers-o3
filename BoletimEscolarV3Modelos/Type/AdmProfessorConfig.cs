using BoletimEscolarVersao3.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimEscolarVersão3Modelos.Type
{
    class AdmProfessorConfig : IEntityTypeConfiguration<AdmProfessor>
    {
        public void Configure(EntityTypeBuilder<AdmProfessor> builder)
        {


            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nome).IsRequired().HasMaxLength(100);
            builder.Property(q => q.Sobrenome).IsRequired().HasMaxLength(100);
            builder.Property(q => q.Cpf).IsRequired().HasMaxLength(100);
            builder.Property(q => q.DataNascimento).IsRequired();
            builder.Property(q => q.Função).IsRequired();


        }
    }
}
