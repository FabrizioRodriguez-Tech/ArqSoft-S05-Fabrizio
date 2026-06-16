using Microsoft.AspNetCore.Mvc;
using CitasApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CitasApp.Controllers
{
    public class PacienteController : Controller
    {
        private static readonly List<Paciente> _pacientes = new List<Paciente>
        {
            new Paciente { Id = 1, Nombre = "Ana García", Email = "ana@mail.com", Telefono = "555-0001" },
            new Paciente { Id = 2, Nombre = "Luis Martínez", Email = "luis@mail.com", Telefono = "555-0002" },
            new Paciente { Id = 3, Nombre = "María López", Email = "maria@mail.com", Telefono = "555-0003" }
        };

        // 1. Cambiado a IActionResult y return View para que cargue la tabla HTML
        public IActionResult Index()
        {
            return View(_pacientes);
        }

        // 2. Cambiado para que también busque su propia vista de detalle si la necesitas después
        public IActionResult Detalle(int id)
        {
            // 1. Buscamos al paciente
            var paciente = _pacientes.FirstOrDefault(p => p.Id == id);
            if (paciente == null) return NotFound("Paciente no encontrado");

            // 2. Traemos la lista de citas simulada (para poder filtrar)
            // Usamos la misma lista en memoria que tienes en CitaController
            var todasLasCitas = new List<Cita>
    {
        new Cita { Id = 1, PacienteId = 1, MedicoId = 1, Fecha = "1/6/2026", FechaHora = "9:00", Motivo = "Consulta general", Estado = "Confirmada" },
        new Cita { Id = 2, PacienteId = 2, MedicoId = 2, Fecha = "1/6/2026", FechaHora = "10:00", Motivo = "Revisión de resultados", Estado = "Pendiente" },
        new Cita { Id = 3, PacienteId = 3, MedicoId = 1, Fecha = "3/6/2026", FechaHora = "11:00", Motivo = "Primera consulta", Estado = "Pendiente" }
    };

            // 3. Filtramos las citas que pertenecen a ESTE paciente en específico
            var citasDelPaciente = todasLasCitas.Where(c => c.PacienteId == id).ToList();

            // 4. Se las enviamos a la vista de forma segura
            ViewBag.Citas = citasDelPaciente;

            return View(paciente);
        }
    }
}