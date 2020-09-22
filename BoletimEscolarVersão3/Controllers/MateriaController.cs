using System;
using System.Linq;
using System.Net;
using BoletimEscolarVersao3.Model;
using BoletimEscolarVersão3Modelos;
using BoletimEscolarVersão3Modelos.Uteis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoletimEscolarVersão3.Controllers
{
    [Route("Materia")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        private readonly BancoContex banco;

        public MateriaController(BancoContex bancoContex)
        {
            banco = bancoContex;
        }

        [HttpPost]
        [Route("Adicionar")]
        public ActionResult Post(Materia materia)
        {
            var result = new Result<Materia>();

            try
            {
                using (banco)
                {


                    var curso = banco.Curso.Where(q => q.Id == materia.IdCurso).FirstOrDefault();
                    if (curso is null)
                    {
                        result.Error = true;
                        result.Message.Add($"O curso cadastrado não existe");
                        result.Status = HttpStatusCode.BadRequest;
                        return Ok(result);
                    }
                    if (curso.Situação == "Desativado")
                    {
                        result.Error = true;
                        result.Message.Add($"O curso está desativado");
                        result.Status = HttpStatusCode.BadRequest;
                        return Ok(result);
                    }

                    banco.Add(materia);
                    banco.SaveChanges();
                    result.Error = false;
                    result.Status = HttpStatusCode.OK;
                    result.Data = banco.Materia.ToList();
                    return Ok(result);
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message.Add(e.Message);
                return BadRequest(result);
            }
        }

        //Mostrar Lista de Materias
        [HttpGet]
        [Route("MostraMateria")]
        public ActionResult Get()
        {
            return Ok(banco.Materia.ToList());
        }

        //Deletar Materia
        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Deletar(int id)
        {

            var resultado = banco.Materia.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            banco.Materia.Remove(resultado);
            banco.SaveChanges();
            return Ok(Resultado.Sucesso);


        }

        //Alterar materia
        [HttpPut]
        [Route("Atualizar")]
        public ActionResult Atualizar(int id, Materia materia)
        {

            var resultado = banco.Materia.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado = materia;
            banco.SaveChanges();
            return Ok(Resultado.Sucesso);

        }
        //Adicionar Nota
        [HttpPost]
        [Route("Nota")]
        public ActionResult AdicionarMateriaCursoNota(int idaluno, int idmateria, double nota)
        {
            var result = new Result<AlunoMateriaNotas>();

            try
            {
                using (banco)
                {
                    //var aluno = banco.Aluno.Where(q => q.Id == idaluno).Include(x => x.Curso).FirstOrDefault();
                    var aluno = banco.Aluno.Where(q => q.Id == idaluno).Include(x => x.MateriasNota).ThenInclude(z => z.Materia).FirstOrDefault();
                    if (aluno is null)
                    {
                        return BadRequest("Aluno não cadastrado ");
                    }
                    var materia = banco.Materia.Where(q => q.Id == idmateria).Include(x => x.Curso).FirstOrDefault();
                    if (materia is null)
                    {
                        return BadRequest("Materia não cadastrada");
                    }
                    var curso = materia.Curso.Materias.Where(q => q.IdCurso == aluno.IdCurso).FirstOrDefault();

                    if (curso is null)
                    {
                        return BadRequest("Materia não faz parte do curso do aluno");
                    }

                    var relaçao = aluno.MateriasNota.Where(q => q.Materia.Id == idmateria).Where(q => q.Aluno.Id == idaluno).FirstOrDefault();
                    if (relaçao != null)
                    {
                        return BadRequest("Nota ja cadastrada");
                    }


                    aluno.MateriasNota.Add(new AlunoMateriaNotas()
                    {
                        Materia = materia,
                        Aluno = aluno,
                        IdAluno = aluno.Id,
                        IdMateria = materia.Id,
                        Nota = nota

                    });

                    banco.SaveChanges();


                    result.Error = false;
                    result.Status = HttpStatusCode.OK;
                    result.Message.Add("ok");
                    result.Data = aluno.MateriasNota.Where(q => q.Aluno.Id == idaluno).ToList();
                    return Ok($"{result.Data} cadsatrado");
                }

            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message.Add(e.Message);
                return BadRequest(result);
            }
        }
        //Alterar nota
        [HttpPut]
        [Route("AtulizarNota")]
        public ActionResult AtualizarNota(int idaluno, int idmateria, double novanota)
        {


            var aluno = banco.Aluno.Where(q => q.Id == idaluno).Include(x => x.MateriasNota).ThenInclude(z => z.Materia).FirstOrDefault();
            var resultado = aluno.MateriasNota.Where(q => q.Materia.Id == idmateria).Where(q => q.Aluno.Id == idaluno).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado.Nota = novanota;
            banco.SaveChanges();
            return Ok(Resultado.Sucesso);


        }

        [HttpGet]
        [Route("FiltroMateria")]
        public ActionResult Filtro(int id)
        {
            var resultado = banco.Materia.Where(q => q.IdCurso == id).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            return Ok(resultado);
        }
    }
}
