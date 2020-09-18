using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace BoletimEscolarVersão3Modelos.Modelos
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public int IdCurso { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Curso Curso { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<AlunoMateriaNotas> Materias { get; set; } = new HashSet<AlunoMateriaNotas>();
    }
}
