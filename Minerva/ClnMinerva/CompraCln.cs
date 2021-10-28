using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class CompraCln
    {
        public static int insertar(Compra compra)
        {
            using (var db = new MinervaEntities())
            {
                db.Compra.Add(compra);
                db.SaveChanges();
                return compra.id;
            }
        }

        public static int actualizar(Compra compra)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Compra.Find(compra.id);
                actualDb.transaccion = compra.transaccion;
                actualDb.fecha = compra.fecha;
                actualDb.idProveedor = compra.idProveedor;
                return db.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Compra.Find(id);
                actualDb.registroActivo = false;
                actualDb.usuarioRegistro = usuarioRegistro;
                return db.SaveChanges();
            }
        }

        public static Compra get(int id)
        {
            using (var db = new MinervaEntities())
            {
                return db.Compra.Find(id);
            }
        }

        public static int getSgteTransaccion()
        {
            using (var db = new MinervaEntities())
            {
                var ultimaCompraAnio = db.Compra.AsEnumerable()
                    .Where(x => x.registroActivo && x.fechaRegistro.Year == DateTime.Now.Year)
                    .LastOrDefault();
                return ultimaCompraAnio != null ? ultimaCompraAnio.transaccion + 1 : 1;
            }
        }

        public static Compra validar(int transaccion)
        {
            using (var db = new MinervaEntities())
            {
                return db.Compra.AsEnumerable()
                    .Where(x => x.transaccion == transaccion && x.fechaRegistro.Year == DateTime.Now.Year)
                    .FirstOrDefault();
            }
        }

        public static List<Compra> listar(int parametro)
        {
            using (var db = new MinervaEntities())
            {
                return db.Compra.AsEnumerable()
                    .Where(x => x.registroActivo && x.transaccion == parametro)
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
