# CitasApp API

Aplicación backend para la gestión de citas médicas, desarrollada con **ASP.NET Core (.NET 10)** bajo una arquitectura de capas, exponiendo un servicio RESTful documentado con **OpenAPI/Scalar**.

## Arquitectura del Proyecto

El sistema está organizado para separar la lógica de negocio, la persistencia y la exposición de datos:

- **Domain:** Define los modelos y los contratos (`Interfaces`) para la persistencia.
- **Application:** Contiene los servicios que orquestan la lógica de negocio entre el dominio y los repositorios.
- **Infrastructure:** Implementación de repositorios basados en archivos JSON para persistencia de datos.
- **Api:** Capa de presentación que expone los endpoints REST.

## Entidades y Funcionalidades

La API permite la gestión de los siguientes recursos:

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

## Documentación y Pruebas (Scalar)

Este proyecto utiliza **Scalar** como interfaz visual para OpenAPI. Permite visualizar los endpoints, ver los modelos de datos y realizar pruebas de las peticiones HTTP directamente desde el navegador.

- **URL de acceso:** Una vez ejecutada la aplicación, accede a `http://localhost:[PUERTO]/scalar/v1`

## Especificaciones Técnicas

- **Framework:** .NET 10.0
- **Documentación:** Microsoft.AspNetCore.OpenApi + Scalar.AspNetCore
- **Inyección de Dependencias:** Registro nativo de servicios y repositorios en `Program.cs`.

## Cómo ejecutar

1. Asegúrate de tener instalado el **SDK de .NET 10**.
2. Clona el repositorio y navega a la carpeta del proyecto.
3. Ejecuta desde la terminal:
   ```bash
   dotnet run --project CitasApp.Api
