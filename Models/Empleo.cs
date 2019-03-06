using System;
namespace Expediente.Models
{
    public class Empleo : Persona
    {
        public Empleo()
        {

        }
        public int EmpleoID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Institucion { get; set; }
        public string Puesto { get; set; }   
        public string Actividad { get; set; }
    }
}