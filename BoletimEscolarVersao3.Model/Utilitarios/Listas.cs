using BoletimEscolarVersao3.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BoletimEscolarVersao3.Utilitarios
{
    public class Listas
    {
        public List<string> ListadeCursos()
        {
            try
            {
                List<string> valores = new List<string>();
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Curso/Mostracursos";
                var resultRequest = httpClient.GetAsync(URL);
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<Curso>>(resultJson);

                    foreach (var curso in data)
                    {
                        valores.Add($"{curso.Id} - {curso.Nome}");
                    }
                }
                return valores;
            }
            catch 
            {
                throw new Exception();
            }

        }
        public bool ListadeCpfAlunos(string cpflogin)
        {
            try
            {
                List<string> cpf = new List<string>();
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Aluno/Mostra";
                var resultRequest = httpClient.GetAsync(URL);
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<Aluno>>(resultJson);

                    foreach (var aluno in data)
                    {
                        cpf.Add(aluno.Cpf);
                    }


                    if (cpf.Contains(cpflogin))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw new Exception();
            }

        }
        public List<string> ListadeMateria(string cb_curso)
        {
            try
            {
                List<string> valores = new List<string>();
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Materia/FiltroMateria";
                var curso = cb_curso;
                curso = curso.Substring(0, curso.IndexOf("-"));
                var resultRequest = httpClient.GetAsync($"{URL}?id={curso}");
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<Materia>>(resultJson);

                    foreach (var materia in data)
                    {
                        valores.Add($"{materia.Id} - {materia.Nome}");
                    }
                }
                return valores;
            }
            catch 
            {
                throw new Exception();
            }
        }
        public List<string> ListadeAlunos(string cb_curso)
        {
            try
            {
                List<string> valores = new List<string>();
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Aluno/FiltroAlunos";
                var curso = cb_curso;
                curso = curso.Substring(0, curso.IndexOf("-"));
                var idcurso = Convert.ToInt32(curso);
                var resultRequest = httpClient.GetAsync($"{URL}?id={idcurso}");
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<Aluno>>(resultJson);

                    foreach (var aluno in data)
                    {
                        valores.Add($"{aluno.Id} - {aluno.Nome} {aluno.Sobrenome}");
                    }
                }
                return valores;
            }
            catch 
            {
                throw new Exception();
            }
        }

    }
}
