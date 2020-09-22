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
    [Route("Aluno")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly BancoContex banco;
        public AlunoController(BancoContex bancoContex)
        {
            banco = bancoContex;
        }

        //Cadastrar aluno
        [HttpPost]
        [Route("Adicionar")] 
        public ActionResult Post(Aluno aluno)
        {
           var result = new Result<Aluno>();

         try
           {
                using (banco)
                {
                    var curso = banco.Curso.Where(q => q.Id == aluno.IdCurso).FirstOrDefault();
                    if (curso is null)
                    {
                        result.Error = true;
                        result.Message.Add($"O curso cadastrado não existe");
                        result.Status = HttpStatusCode.BadRequest;
                        return Ok(Resultado.NãoSucesso);
                    }
                    if (curso.Situação == "Inativo")
                    {
                        result.Error = true;
                        result.Message.Add($"O curso está desativado");
                        result.Status = HttpStatusCode.BadRequest;
                        return Ok(Resultado.NãoSucesso);
                    }
                    banco.Add(aluno);
                    banco.SaveChanges();
                    result.Error = false;
                    result.Status = HttpStatusCode.OK;
                    result.Data = banco.Aluno.ToList();
                    return Ok(Resultado.Sucesso);
                }
            }
            catch (Exception e)
            {
                result.Error = true;
                result.Message.Add(e.Message);
                return BadRequest(Resultado.NãoSucesso);
            }
        }

        //Mostrar Lista de Alunos
        [HttpGet]
        [Route("Mostra")]
        public ActionResult Get()
        {
            return Ok(banco.Aluno.ToList());
        }

        //Deletar Aluno
        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Deletar(int id)
        {

            var resultado = banco.Aluno.Where(q => q.Id == id).FirstOrDefault();
            if (resultado == null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            banco.Aluno.Remove(resultado);
            banco.SaveChanges();
            return Ok(banco.Aluno);

        }

        //Alterar aluno
        [HttpPut]
        [Route("Atulizar")]
        public ActionResult Atualizar(int id, Aluno aluno)
        {

            var resultado = banco.Aluno.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado = aluno;
            banco.SaveChanges();
            return Ok(Resultado.Sucesso);

        }

        //Listar Notas
        [HttpGet]
        [Route("ListarNotas")]
        public ActionResult ListarNotas(string cpf, int id)
        {
            var busca = banco.Aluno.Where(q => q.Cpf == cpf).Include(x => x.MateriasNota).ThenInclude(z => z.Materia).FirstOrDefault();
            if (busca is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            return Ok(busca.MateriasNota);
        }

        [HttpGet]
        [Route("FiltroAlunos")]
        public ActionResult Filtro(int id)
        {
            var resultado = banco.Aluno.Where(q => q.IdCurso == id).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            return Ok(resultado);
        }
    }
}
