using System;
using System.Collections.Generic;

#nullable disable

namespace CpMinervaWebNetCore.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Compras = new HashSet<Compra>();
        }

        public int Id { get; set; }
        public long Nit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Representante { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? RegistroActivo { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
