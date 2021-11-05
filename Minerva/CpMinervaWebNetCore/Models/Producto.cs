using System;
using System.Collections.Generic;

#nullable disable

namespace CpMinervaWebNetCore.Models
{
    public partial class Producto
    {
        public Producto()
        {
            CompraDetalles = new HashSet<CompraDetalle>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Saldo { get; set; }
        public decimal PrecioVenta { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? RegistroActivo { get; set; }

        public virtual ICollection<CompraDetalle> CompraDetalles { get; set; }
    }
}
