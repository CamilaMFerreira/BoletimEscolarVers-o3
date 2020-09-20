using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BoletimEscolarVersão3Modelos.Modelos
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Situação { get; set; }
        public int IdCurso { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Curso Curso { get; set; }
        
        [JsonIgnore]
        [IgnoreDataMember]
        
        public virtual ICollection<AlunoMateriaNotas> AlunoNota { get; set; } = new HashSet<AlunoMateriaNotas>();
    }
}
