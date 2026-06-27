# CitasApp - Rama: gof

App de citas médicas evolucionada hacia una arquitectura en capas con implementación de patrones de diseño GOF.

## Descripción del Proyecto
El enfoque principal es la mejora de la mantenibilidad y la observabilidad mediante el uso de patrones de diseño.

## Arquitectura actual
El proyecto ha sido reestructurado para separar responsabilidades:

*   **CitasApp.Domain**: Entidades y contratos (interfaces) del sistema.
*   **CitasApp.Application**: Lógica de servicios (orquesta el flujo de negocio).
*   **CitasApp.Infrastructure**: Implementación de repositorios y persistencia.
*   **CitasApp.Api**: Punto de entrada RESTful.
*   **CitasApp.Web**: Cliente MVC

## Patrones GOF Implementados

### 1. Factory (RepositoryFactory)
*   **Propósito**: Desacoplar la creación de repositorios de la capa de aplicación.
*   **Implementación**: `RepositoryFactory` permite inyectar la instancia correcta del repositorio según el entorno o configuración, evitando instanciación directa (`new`) en los servicios.

### 2. Decorator (LoggingPacienteRepository)
*   **Propósito**: Añadir funcionalidad transversal (Cross-cutting concern) sin alterar la lógica central del repositorio.
*   **Implementación**: `LoggingPacienteRepository` envuelve al repositorio original, permitiendo registrar logs con timestamps de forma automática en cada operación (`ObtenerTodos`, `ObtenerPorId`, etc.).

## Estructura de Navegación / Endpoints
La API expone los siguientes recursos a través de los servicios de aplicación:

### Pacientes
* `GET /api/pacientes` — Lista todos los pacientes registrados.
* `GET /api/pacientes/{id}` — Obtiene el detalle de un paciente específico.
* `POST /api/pacientes` — Registra un nuevo paciente en el sistema.

### Médicos
* `GET /api/medicos` — Obtiene el catálogo de personal médico.
* `GET /api/medicos/{id}` — Detalle de un médico específico.

### Citas
* `GET /api/citas` — Agenda completa de citas.
* `GET /api/citas/porpaciente/{pacienteId}` — Filtra las citas asociadas a un paciente.
* `POST /api/citas` — Crea una nueva cita.
* `POST /api/citas/confirmar/{citaId}` — Confirma una cita programada.

### API REST
*   `GET /api/pacientes` — Lista de pacientes (loggeada mediante Decorator).
*   `GET /api/pacientes/{id}` — Detalle de un paciente.

### Web (MVC)
*   `/Paciente` — Interfaz de consulta de pacientes.
*   `/Medico` — Catálogo de personal de salud.
*   `/Cita` — Agenda general.

## Estado del Proyecto
*   ✅ **Arquitectura**: Migrada a un diseño en capas con Inyección de Dependencias.
*   ✅ **Patrones**: Factory y Decorator operativos.
*   ⏳ **Pendientes**: Implementación del patrón Observer para notificaciones.

---
*Rama configurada para .NET 10.0*
