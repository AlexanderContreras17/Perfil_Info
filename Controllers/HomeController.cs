using InformacionApp.Models;
using InformacionApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace InformacionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel vm = new()
            {
                Nombre = "Alexander",
                Materia = "Algebra",
                semestre = 7,
                periodo = 1
            };

            return View(vm);
        }
        public IActionResult MiPerfil()
        {
            IndexViewModel mp = new()
            {
                Nombre = "Juan Alexander Contreras",
                Carrera = "Sistemas",
                Correo = "201G0240@rcarbonifera.tecnm.mx",
                semestre = 7,
                NumeroControl = "201G0240"

            };
            return View(mp);
        }
    }
}
