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

        // Cambiamos JsonResult por "object" para evitar cualquier error de configuración
        public object Index()
        {
            return _pacientes;
        }

        public IActionResult Detalle(int id)
        {
            var paciente = _pacientes.FirstOrDefault(p => p.Id == id);
            if (paciente == null) return NotFound("Paciente no encontrado");

            return Ok(paciente); // Uso de "Ok" en lugar de "Json"
        }
    }
}