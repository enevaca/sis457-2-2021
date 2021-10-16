using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class EmpleadoCln
    {
        public static int insertar(Empleado empleado) 
        {
            using (var db = new MinervaEntities())
            {
                db.Empleado.Add(empleado);
                db.SaveChanges();
                return empleado.id;
            }
        }

        public static int actualizar(Empleado empleado) 
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Empleado.Find(empleado.id);
                actualDb.cedulaIdentidad = empleado.cedulaIdentidad;
                actualDb.nombres = empleado.nombres;
                actualDb.paterno = empleado.paterno;
                actualDb.materno = empleado.materno;
                actualDb.fechaNacimiento = empleado.fechaNacimiento;
                actualDb.direccion = empleado.direccion;
                actualDb.celular = empleado.celular;
                actualDb.cargo = empleado.cargo;
                return db.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro) 
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Empleado.Find(id);
                actualDb.registroActivo = false;
                actualDb.usuarioRegistro = usuarioRegistro;
                return db.SaveChanges();
            }
        }

        public static Empleado get(int id) 
        {
            using (var db = new MinervaEntities())
            {
                return db.Empleado.Find(id);
            }
        }

        public static Empleado validar(string cedulaIdentidad)
        {
            using (var db = new MinervaEntities())
            {
                return db.Empleado.Where(x => x.cedulaIdentidad == cedulaIdentidad).FirstOrDefault();
            }
        }

        public static List<Empleado> listar(string parametro) 
        {
            using (var db = new MinervaEntities())
            {
                return db.Empleado.AsEnumerable()
                    .Where(x => x.registroActivo && (x.nombres+x.paterno+x.materno).Contains(parametro))
                    .ToList();
            }
        }

        public static List<paEmpleadoListar_Result> listarPa(string parametro) 
        {
            using (var db = new MinervaEntities())
            {
                return db.paEmpleadoListar(parametro).ToList();
            }
        }
    }
}
