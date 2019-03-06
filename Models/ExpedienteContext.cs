using System;
using Microsoft.EntityFrameworkCore;

namespace Expediente.Models
{
    public class ExpedienteContext : DbContext
    {
        public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<Persona> Personas { get; set; }

        public ExpedienteContext(DbContextOptions<ExpedienteContext> options) : base(options)
        {

        }
/* 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var expediente = new Expediente();
            DateTime thisDay = DateTime.Today;

            expediente.PersonaId = Guid.NewGuid().ToString();
            expediente.Rfc = "MAMC8511107C3";
            expediente.Curp = "MAMC851110HYNRXR03";
            expediente.Nombre = "Carlos";
            expediente.ApellidoMaterno = "Martinez";
            expediente.ApellidoPaterno = "Muñoz";
            expediente.Plantel = Plantel.JesusMartinezRoss;
            expediente.FechaCreacion = thisDay;
 
            modelBuilder.Entity<Expediente>().HasData(expediente);
        }
*/
    }
}