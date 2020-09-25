using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BoletimEscolarVersao3.Model.Model;
using BoletimEscolarVersão3Modelos;
using BoletimEscolarVersão3Modelos.Uteis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletimEscolarVersão3.Controllers
{
    [Route("AdmProfessor")]
    [ApiController]
    public class AdmProfessorController : ControllerBase
    {
        private readonly BancoContex banco;
        public AdmProfessorController(BancoContex bancoContex)
        {
            banco = bancoContex;
        }

        //Cadastrar adm ou professor
        [HttpPost]
        [Route("Adicionar")]
        public ActionResult Post(AdmProfessor pessoa)
        {
            var result = new Result<AdmProfessor>();

            try
            {
                using (banco)
                {
                    
                    
                    banco.Add(pessoa);
                    banco.SaveChanges();
                    result.Error = false;
                    result.Status = HttpStatusCode.OK;
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

        //Mostrar Lista de Adm e professores
        [HttpGet]
        [Route("Mostra")]
        public ActionResult Get()
        {
            return Ok(banco.AdmProfessor.ToList());
        }

        

        //Alterar aluno
        [HttpPut]
        [Route("Atulizar")]
        public ActionResult Atualizar(int id, AdmProfessor pessoa)
        {

            var resultado = banco.AdmProfessor.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado = pessoa;
            banco.SaveChanges();
            return Ok(Resultado.Sucesso);

        }

    }
}
