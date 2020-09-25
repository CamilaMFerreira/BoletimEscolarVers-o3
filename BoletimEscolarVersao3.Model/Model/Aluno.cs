using BoletimEscolarVersao3.Model.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BoletimEscolarVersao3.Model
{
    public class Aluno :Pessoa
    {
       
        public int IdCurso { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Curso Curso { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<AlunoMateriaNotas> MateriasNota { get; set; } = new HashSet<AlunoMateriaNotas>();
    }
}
