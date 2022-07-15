using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Alura.Models;

namespace WebAPI_Alura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {

        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionaFilme(Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
    }
}