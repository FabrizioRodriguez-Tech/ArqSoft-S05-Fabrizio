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

        // Al escribir /Cita en el navegador
        public object Index()
        {
            return _citas;
        }

        // Al escribir /Cita/PorPaciente?pacienteId=1
        public object PorPaciente(int pacienteId)
        {
            var filtradas = _citas.Where(c => c.PacienteId == pacienteId).ToList();
            return filtradas;
        }
    }
}