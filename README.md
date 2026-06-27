# CitasApp API

Aplicación backend para la gestión de citas médicas, desarrollada con **ASP.NET Core (.NET 10)** bajo una arquitectura de capas, exponiendo un servicio RESTful documentado con **OpenAPI/Scalar**.

## Arquitectura del Proyecto

El sistema está organizado para separar la lógica de negocio, la persistencia y la exposición de datos:

- **Domain:** Define los modelos y los contratos (`Interfaces`) para la persistencia.
- **Application:** Contiene los servicios que orquestan la lógica de negocio entre el dominio y los repositorios.
- **Infrastructure:** Implementación de repositorios basados en archivos JSON para persistencia de datos.
- **Api:** Capa de presentación que expone los endpoints REST.

## Especificaciones Técnicas y Notas de Desarrollo

- **Framework:** .NET 10.0.
- **Arquitectura Asíncrona:** La API implementa el patrón `async/await` en la comunicación entre controladores y servicios. Esto garantiza operaciones de E/S no bloqueantes, permitiendo que el servidor gestione múltiples peticiones concurrentes de forma eficiente sin degradar el rendimiento.
- **Inyección de Dependencias:** Registro nativo de servicios y repositorios en `Program.cs`.

## Documentación y Pruebas (Scalar)

Este proyecto utiliza **Scalar** como interfaz visual para OpenAPI.

**¿Por qué Scalar?**
Se seleccionó Scalar por ofrecer una interfaz moderna, reactiva y orientada a la experiencia del desarrollador. A diferencia de las herramientas tradicionales de Swagger, Scalar permite una navegación más fluida, una mejor visualización de los modelos de datos y la ejecución de pruebas de peticiones HTTP directamente desde el navegador de forma intuitiva.

- **URL de acceso:** `https://localhost:44355/scalar/v1`

## Pruebas desde Terminal (PowerShell)

Para realizar pruebas desde la terminal en un entorno de desarrollo con certificados HTTPS autofirmados, se utiliza `curl.exe` con la bandera `-k` (insecure). Esta configuración es necesaria para omitir la validación de certificados de desarrollo, permitiendo establecer la conexión sin errores de seguridad SSL.

**Comandos recomendados:**

- **Pacientes:** `curl.exe -k https://localhost:44355/api/pacientes`
- **Médicos:** `curl.exe -k https://localhost:44355/api/medicos`
- **Citas:** `curl.exe -k https://localhost:44355/api/citas`

## Entidades y Funcionalidades

- **Pacientes:** Registro y consulta de información.
- **Médicos:** Directorio de profesionales disponibles.
- **Citas:** Gestión integral de agenda.
  - `GET /api/citas`: Listado completo de citas.
  - `GET /api/citas/paciente/{pacienteId}`: Filtrado de citas por paciente.
  - `POST /api/citas`: Registro de una nueva cita.

## Persistencia

- **Almacenamiento:** Archivos JSON ubicados en `data/`.
- **Estructura:**
  - `data/pacientes.json`
  - `data/medicos.json`
  - `data/citas.json`

## Cómo ejecutar

1. Asegúrate de tener instalado el **SDK de .NET 10**.
2. Clona el repositorio y navega a la carpeta del proyecto.
3. Ejecuta desde la terminal:
   ```bash
   dotnet run --project CitasApp.Api
