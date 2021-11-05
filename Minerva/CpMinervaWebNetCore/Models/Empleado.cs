using System;
using System.Collections.Generic;

#nullable disable

namespace CpMinervaWebNetCore.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string CedulaIdentidad { get; set; }
        public string Nombres { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public long Celular { get; set; }
        public string Cargo { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? RegistroActivo { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
