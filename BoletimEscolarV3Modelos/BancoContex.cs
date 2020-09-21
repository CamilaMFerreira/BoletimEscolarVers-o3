using BoletimEscolarVersao3.Model;
using Microsoft.EntityFrameworkCore;

namespace BoletimEscolarVersão3Modelos
{
    public class BancoContex : DbContext
    {
        public BancoContex()
        {

        }
        public BancoContex(DbContextOptions<BancoContex> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoContex).Assembly);

            modelBuilder.Entity<Aluno>()
           .HasOne(p => p.Curso)
           .WithMany(b => b.Alunos)
           .HasForeignKey(p => p.IdCurso);



            modelBuilder.Entity<Materia>()
         .HasOne(p => p.Curso)
         .WithMany(b => b.Materias)
         .HasForeignKey(p => p.IdCurso);

            modelBuilder.Entity<AlunoMateriaNotas>().HasKey(sc => new { sc.IdAluno, sc.IdMateria });
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Materia> Materia { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server==NT-03374\\SQLEXPRESS;Database=master;Initial Catalog=BoletimV4;");
            //}

            base.OnConfiguring(optionsBuilder);
        }


    }
}

