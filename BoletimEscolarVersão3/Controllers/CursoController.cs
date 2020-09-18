using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BoletimEscolarVersão3Modelos;
using BoletimEscolarVersão3Modelos.Modelos;
using BoletimEscolarVersão3Modelos.Uteis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletimEscolarVersão3.Controllers
{
    [Route("Curso")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly BancoContex banco;
        public CursoController(BancoContex bancoContex)
        {
            banco = bancoContex;
        }

        //Cadastrar Curso
        [HttpPost]
        [Route("Adicionar")]
        public ActionResult Post(Curso curso)
        {
            var result = new Result<Curso>();

            try
            {
                using (banco)
                {
                    banco.Add(curso);
                    banco.SaveChanges();
                    result.Error = false;
                    result.Status = HttpStatusCode.OK;
                    result.Data = banco.Curso.ToList();
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

        //Mostrar Lista de Cursos
        [HttpGet]
        [Route("MostraAlunos")]
        public ActionResult Get()
        {
            return Ok(banco.Curso);
        }

        //Deletar Curso
        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Deletar(int id)
        {

            var resultado = banco.Curso.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            banco.Curso.Remove(resultado);
            banco.SaveChanges();
            return Ok(Resultado.Sucesso);


        }
    }
}
