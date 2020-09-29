using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimEscolarVersao3.Model.Utilitarios
{
    public class Verificador
    {
        public bool Valido { get; set; }
        public string Erros { get; set; }

        public Verificador()
        {
            Valido = true;
        }

    }
}
