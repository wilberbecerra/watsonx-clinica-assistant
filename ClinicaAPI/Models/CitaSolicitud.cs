namespace ClinicaAPI.Models
{
    public class CitaSolicitud
    {
        
        public string Especialidad { get; set; } = ""; 
       
        public string NombreCompleto { get; set; } = "";
        
        public string NumeroDocumento { get; set; } = ""; 
       
        public DateTime FechaCitaDeseada { get; set; }
       
        public string RangoHorario { get; set; } = "";
      
        public string HoraExacta { get; set; } = "";
    }

}

