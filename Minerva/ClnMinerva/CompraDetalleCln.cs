using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class CompraDetalleCln
    {
        public static int insertar(CompraDetalle compraDetalle)
        {
            using (var db = new MinervaEntities())
            {
                db.CompraDetalle.Add(compraDetalle);
                db.SaveChanges();
                return compraDetalle.id;
            }
        }

        public static int actualizar(CompraDetalle compraDetalle)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.CompraDetalle.Find(compraDetalle.id);
                actualDb.cantidad = compraDetalle.cantidad;
                actualDb.precioUnitario = compraDetalle.precioUnitario;
                actualDb.total = compraDetalle.total;
                actualDb.idCompra = compraDetalle.idCompra;
                actualDb.idProducto = compraDetalle.idProducto;
                return db.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.CompraDetalle.Find(id);
                actualDb.registroActivo = false;
                actualDb.usuarioRegistro = usuarioRegistro;
                return db.SaveChanges();
            }
        }

        public static CompraDetalle get(int id)
        {
            using (var db = new MinervaEntities())
            {
                return db.CompraDetalle.Find(id);
            }
        }

        public static List<CompraDetalle> listar(int idCompra)
        {
            using (var db = new MinervaEntities())
            {
                return db.CompraDetalle.AsEnumerable()
                    .Where(x => x.registroActivo && x.idCompra == idCompra)
                    .ToList();
            }
        }

        //public static List<paCompraListar_Result> listarPa(string parametro)
        //{
        //    using (var db = new MinervaEntities())
        //    {
        //        return db.paCompraListar(parametro).ToList();
        //    }
        //}
    }
}
