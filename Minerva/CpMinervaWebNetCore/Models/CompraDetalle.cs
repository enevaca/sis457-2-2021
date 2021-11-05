using System;
using System.Collections.Generic;

#nullable disable

namespace CpMinervaWebNetCore.Models
{
    public partial class CompraDetalle
    {
        public int Id { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? RegistroActivo { get; set; }

        public virtual Compra IdCompraNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
