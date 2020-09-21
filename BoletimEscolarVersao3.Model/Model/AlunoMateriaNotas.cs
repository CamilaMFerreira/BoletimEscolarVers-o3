namespace BoletimEscolarVersao3.Model
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
