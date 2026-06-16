using Microsoft.AspNetCore.Mvc;
using CitasApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CitasApp.Controllers
{
    public class MedicoController : Controller
    {
        private static readonly List<Medico> _medicos = new List<Medico>
        {
            new Medico { Id = 1, Nombre = "Dr. Carlos Reyes", Especialidad = "Medicina General", NumeroLicencia = "MG-10421" },
            new Medico { Id = 2, Nombre = "Dra. Patricia Vega", Especialidad = "Pediatría", NumeroLicencia = "PD-20835" },
            new Medico { Id = 3, Nombre = "Dr. Roberto Sánchez", Especialidad = "Cardiología", NumeroLicencia = "CA-30117" }
        };

        // 1. Cambiado a IActionResult y return View para que renderice la tabla HTML
        public IActionResult Index()
        {
            return View(_medicos);
        }

        // 2. Cambiado para que busque su respectiva vista de detalle si se requiere
        public IActionResult Detalle(int id)
        {
            var medico = _medicos.FirstOrDefault(m => m.Id == id);
            if (medico == null) return NotFound("Médico no encontrado");

            return View(medico);
        }
    }
}