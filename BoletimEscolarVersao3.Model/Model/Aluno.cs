using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BoletimEscolarVersao3.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public string Função { get; set; }
        public int IdCurso { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Curso Curso { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<AlunoMateriaNotas> MateriasNota { get; set; } = new HashSet<AlunoMateriaNotas>();
    }
}
