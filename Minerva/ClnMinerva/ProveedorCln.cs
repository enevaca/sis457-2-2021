using CadMinerva;
using System.Collections.Generic;
using System.Linq;

namespace ClnMinerva
{
    public class ProveedorCln
    {
        public static int insertar(Proveedor proveedor)
        {
            using (var db = new MinervaEntities())
            {
                db.Proveedor.Add(proveedor);
                db.SaveChanges();
                return proveedor.id;
            }
        }

        public static int actualizar(Proveedor proveedor)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Proveedor.Find(proveedor.id);
                actualDb.nit = proveedor.nit;
                actualDb.razonSocial = proveedor.razonSocial;
                actualDb.direccion = proveedor.direccion;
                actualDb.telefono = proveedor.telefono;
                actualDb.representante = proveedor.representante;
                return db.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Proveedor.Find(id);
                actualDb.registroActivo = false;
                actualDb.usuarioRegistro = usuarioRegistro;
                return db.SaveChanges();
            }
        }

        public static Proveedor get(int id)
        {
            using (var db = new MinervaEntities())
            {
                return db.Proveedor.Find(id);
            }
        }

        public static Proveedor validar(long nit)
        {
            using (var db = new MinervaEntities())
            {
                return db.Proveedor.Where(x => x.nit == nit).FirstOrDefault();
            }
        }

        public static List<Proveedor> listar(string parametro)
        {
            using (var db = new MinervaEntities())
            {
                return db.Proveedor.AsEnumerable()
                    .Where(x => x.registroActivo && (x.nit + x.razonSocial).Contains(parametro))
                    .ToList();
            }
        }
    }
}
