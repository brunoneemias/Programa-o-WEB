using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TransporteExecutivo.Models;

namespace TransporteExecutivo.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceberCadastro([FromForm])
        {
            Usuario usuario = new Usuario();

            if (ModelState.IsValid)
            {   
                string conteudo
                return;
            }
            else
            {


                return View(" Index")
            } 
        }
    }
}
