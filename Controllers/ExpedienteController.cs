using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Expediente.Models;

namespace Expediente.Controllers
{
    public class ExpedienteController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var persona = _context.Personas.FirstOrDefault();
                return View(persona);
            }
            catch (Exception)
            {
                ViewBag.Mensaje="No existe la tabla de la base de datos";
                return View();
            }







            
        }
        private ExpedienteContext _context;
        public ExpedienteController(ExpedienteContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Persona persona)
        {
            ViewBag.Fecha = DateTime.Now;
            _context.Personas.Add(persona);
            _context.SaveChanges();

            return View();

        }

        public IActionResult MultiPersona()
        {

            ViewBag.Fecha = DateTime.Now;

            return View("MultiPersona", _context.Personas);
        }
    }
}
