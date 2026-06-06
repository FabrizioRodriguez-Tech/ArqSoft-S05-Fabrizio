using Microsoft.AspNetCore.Mvc;
using CitasApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CitasApp.Controllers
{
    public class CitaController : Controller
    {
        private static readonly List<Cita> _citas = new List<Cita>
        {
            new Cita { Id = 1, PacienteId = 1, MedicoId = 1, Fecha = "1/6/2026", FechaHora = "9:00", Motivo = "Consulta general", Estado = "Confirmada" },
            new Cita { Id = 2, PacienteId = 2, MedicoId = 2, Fecha = "1/6/2026", FechaHora = "10:00", Motivo = "Revisión de resultados", Estado = "Pendiente" },
            new Cita { Id = 3, PacienteId = 3, MedicoId = 1, Fecha = "3/6/2026", FechaHora = "11:00", Motivo = "Primera consulta", Estado = "Pendiente" }
        };

        // Creamos copias locales de los catálogos para poder cruzar la información de los nombres
        private static readonly List<Paciente> _pacientes = new List<Paciente>
        {
            new Paciente { Id = 1, Nombre = "Ana García" },
            new Paciente { Id = 2, Nombre = "Luis Martínez" },
            new Paciente { Id = 3, Nombre = "María López" }
        };

        private static readonly List<Medico> _medicos = new List<Medico>
        {
            new Medico { Id = 1, Nombre = "Dr. Carlos Reyes" },
            new Medico { Id = 2, Nombre = "Dra. Patricia Vega" },
            new Medico { Id = 3, Nombre = "Dr. Roberto Sánchez" }
        };

        // 1. Cambiado a IActionResult para renderizar HTML y usando ViewBag para pasar los nombres
        public IActionResult Index()
        {
            ViewBag.Pacientes = _pacientes;
            ViewBag.Medicos = _medicos;
            return View(_citas);
        }

        // 2. Cambiado para que la vista filtrada por paciente también sea HTML visual
        public IActionResult PorPaciente(int pacienteId)
        {
            ViewBag.Pacientes = _pacientes;
            ViewBag.Medicos = _medicos;

            var filtradas = _citas.Where(c => c.PacienteId == pacienteId).ToList();
            return View(filtradas);
        }
    }
}