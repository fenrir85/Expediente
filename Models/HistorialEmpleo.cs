
using System.Collections.Generic;

namespace Expediente.Models
{
    public class HistorialEmpleo : Persona
    {
        public List<Empleo>  Empleos { get; set; }
    }
}