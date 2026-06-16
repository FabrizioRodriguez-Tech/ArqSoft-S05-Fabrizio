namespace CitasApp.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public string Fecha { get; set; } = string.Empty;    
        public string FechaHora { get; set; } = string.Empty; 
        public string Motivo { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}