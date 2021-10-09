using CadMinerva;
using System.Collections.Generic;
using System.Linq;

namespace ClnMinerva
{
    public class ProductoCln
    {
        public static int insertar(Producto producto) // INSERT INTO Producto(...) VALUES(...)
        {
            using (var db = new MinervaEntities())
            {
                db.Producto.Add(producto);
                db.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto) //UPDATE Producto SET ... WHERE id={id}
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Producto.Find(producto.id);
                actualDb.codigo = producto.codigo;
                actualDb.descripcion = producto.descripcion;
                actualDb.unidadMedida = producto.unidadMedida;
                actualDb.saldo = producto.saldo;
                actualDb.precioVenta = producto.precioVenta;
                return db.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro) //UPDATE Producto SET registroActivo=0, usuarioRegistro='{valor}' WHERE id={id}
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Producto.Find(id);
                actualDb.registroActivo = false;
                actualDb.usuarioRegistro = usuarioRegistro;
                return db.SaveChanges();
            }
        }

        public static Producto get(int id) //SELECT * FROM Producto Where id={id}
        {
            using (var db = new MinervaEntities())
            {
                return db.Producto.Find(id);
            }
        }

        public static List<Producto> listar(string parametro) //SELECT * FROM Producto Where registroActivo=1 AND descripcion LIKE '%{parametro}%'
        {
            using (var db = new MinervaEntities())
            {
                return db.Producto.AsEnumerable()
                    .Where(x => x.registroActivo && x.descripcion.Contains(parametro))
                    .ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro) //EXEC paProductoListar '{parametro}'
        {
            using (var db = new MinervaEntities())
            {
                return db.paProductoListar(parametro).ToList();
            }
        }
    }
}
