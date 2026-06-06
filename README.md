# CitasApp

App de citas médicas construida con ASP.NET Core MVC (.NET 8).

## Entidades
- **Paciente** — lista y detalle de pacientes registrados con sus citas asociadas
- **Médico** — catálogo de personal médico disponible con especialidades
- **Cita** — agenda completa mapeada dinámicamente con nombres reales y filtro por paciente

## Persistencia
Colecciones estáticas en memoria — sin base de datos ni archivos externos.
- Datos simulados directamente dentro de los Controladores
- Estructuras simplificadas usando tipos estándar para agilizar la consistencia

## Arquitectura
Patrón Controlador-Vista (MVC) puro con paso de datos dinámicos.
- `Controllers/` — lógica de negocio, colecciones estáticas y mapeo mediante `ViewBag`
- `Models/` — entidades base adaptadas (`Paciente`, `Medico`, `Cita`)
- `Views/` — plantillas Razor con diseño responsivo basado en tablas de Bootstrap 5

## Navegación
- `/Paciente` — lista estructurada de pacientes
- `/Paciente/Detalle/{id}` — ficha del paciente e historial de sus citas filtradas
- `/Medico` — catálogo del personal de salud
- `/Cita` — agenda general con los nombres de pacientes y médicos resueltos

## Requisitos
- .NET 8.0
- Visual Studio 2022
