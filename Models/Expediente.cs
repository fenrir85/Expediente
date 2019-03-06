using System;

namespace Expediente.Models
{
    public class Expediente : Persona
    {
        public Expediente()
        {
        }

        public Expediente(DateTime fechaCreacion, Plantel plantel)
        {
            this.FechaCreacion = fechaCreacion;
            this.Plantel = plantel;

        }
        public DateTime FechaCreacion { get; set; }
        public Plantel Plantel { get; set; }
    }
}

