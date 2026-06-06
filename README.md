# CitasApp

App de citas médicas construida con ASP.NET Core MVC (.NET 10).

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

##Capturas
  
<img width="1918" height="1077" alt="image" src="https://github.com/user-attachments/assets/aa1227b5-7800-42b2-961b-7b30aa4a2320" />
<img width="1918" height="1078" alt="image" src="https://github.com/user-attachments/assets/26695801-dc28-4db2-9745-9780c38580d2" />
<img width="1918" height="1078" alt="image" src="https://github.com/user-attachments/assets/10c9dcd3-cd19-4870-9567-3616f847b549" />
<img width="1918" height="1078" alt="image" src="https://github.com/user-attachments/assets/ce9551de-120f-4910-b588-abce4832470b" />

