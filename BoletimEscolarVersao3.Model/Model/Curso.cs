using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BoletimEscolarVersao3.Model
{ 
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Situação { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public ICollection<Materia> Materias { get; set; } = new HashSet<Materia>();
        [JsonIgnore]
        [IgnoreDataMember]
        public ICollection<Aluno> Alunos { get; set; } = new HashSet<Aluno>();
    }
}
