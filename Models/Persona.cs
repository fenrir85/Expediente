using System;

namespace Expediente.Models
{
    public class Persona
    {
        public Persona()
        {
        }

        public string PersonaId { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }

        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        
        public string ApellidoMaterno { get; set; } 
    }
}