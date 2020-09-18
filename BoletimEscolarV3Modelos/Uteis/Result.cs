using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BoletimEscolarVersão3Modelos.Uteis
{
    public class Result<T>
    {


        public List<T> Data { get; set; }
        public bool Error { get; set; }
        public List<string> Message { get; set; } = new List<string>();
        public HttpStatusCode Status { get; set; }


    }
}
