# Arquitectura del Sistema — CitasApp

Este documento describe la estructura arquitectónica actual de la solución **CitasApp**, detallando la organización de sus componentes en N-Capas, el flujo de datos y la integración de la API REST y el portal Web.


## Diagrama de Arquitectura (N-Capas)

El siguiente diagrama refleja el estado real y actual de la solución en Visual Studio, mostrando cómo conviven la interfaz MVC y la API REST consumiendo el mismo núcleo de negocio.

```mermaid
graph TD
    %% Capas de Presentación
    subgraph Presentacion [Capa de Presentación / Clientes]
        Web[CitasApp.Web <br> Portal MVC - Vistas Razor]
        Api[CitasApp.Api <br> API REST - OpenAPI/Scalar]
    end

    %% Capa de Aplicación
    subgraph Aplicacion [Capa de Aplicación]
        CitaSvc[CitaService.cs]
        MedSvc[MedicoService.cs]
        PacSvc[PacienteService.cs]
    end

    %% Capa de Infraestructura
    subgraph Infraestructura [Capa de Infraestructura]
        Factory[RepositoryFactory.cs]
        subgraph Estrategias [Estrategias de Repositorio]
            JsonCita[JsonCitaRepository.cs]
            JsonMed[JsonMedicoRepository.cs]
            JsonPac[JsonPacienteRepository.cs]
            LogPac[LogginPacienteRepository.cs]
            MemPac[MemoriaPacienteRepository.cs]
        end
    end

    %% Capa de Dominio
    subgraph Dominio [Capa de Dominio]
        DomainEntities[Modelos / Entidades <br> Paciente, Medico, Cita]
        DomainInterfaces[Contratos / Interfaces <br> ICitaRepository, etc.]
    end

    %% Persistencia
    subgraph Persistencia [Persistencia de Datos]
        JsonFiles[(Archivos .json <br> citas, medicos, pacientes)]
    end

    %% Acoplamientos y Dependencias
    Web --> Aplicacion
    Api --> Aplicacion
    
    Aplicacion --> Dominio
    Infraestructura --> Dominio
    
    %% Inyección y configuración de fábricas
    Web -.-> Infraestructura
    Api -.-> Infraestructura

    %% Flujo de almacenamiento
    JsonCita --> JsonFiles
    JsonMed --> JsonFiles
    JsonPac --> JsonFiles
