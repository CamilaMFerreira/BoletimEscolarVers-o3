using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimEscolarVersao3.Model.Model
{


    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Função { get; set; }
    }

}
