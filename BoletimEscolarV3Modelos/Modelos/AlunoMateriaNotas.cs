using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimEscolarVersão3Modelos.Modelos
{
    public class AlunoMateriaNotas
    {
        public int IdMateria { get; set; }
        public Materia Materia { get; set; }
        public int IdAluno { get; set; }
        public Aluno Aluno { get; set; }
        public double Nota { get; set; }
    }
}
