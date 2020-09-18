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
        [Route("MostraAlunos")]
        public ActionResult Get()
        {
            return Ok(banco.Materia);
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
    }
}
