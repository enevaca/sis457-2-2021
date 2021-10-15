using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class UsuarioCln
    {
        public static int insertar(Usuario usuario)
        {
            using (var db = new MinervaEntities())
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return usuario.id;
            }
        }

        public static int actualizar(Usuario usuario)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Usuario.Find(usuario.id);
                actualDb.usuario = usuario.usuario;
                actualDb.idEmpleado = usuario.idEmpleado;
                return db.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var db = new MinervaEntities())
            {
                var actualDb = db.Usuario.Find(id);
                actualDb.registroActivo = false;
                actualDb.usuarioRegistro = usuarioRegistro;
                return db.SaveChanges();
            }
        }

        public static Usuario get(int id)
        {
            using (var db = new MinervaEntities())
            {
                return db.Usuario.Find(id);
            }
        }

        public static Usuario validar(string usuario, string clave)
        {
            using (var db = new MinervaEntities())
            {
                return db.Usuario.Where(x => x.registroActivo && x.usuario == usuario && x.clave == clave).FirstOrDefault();
            }
        }

        public static List<Usuario> listar(string parametro)
        {
            using (var db = new MinervaEntities())
            {
                return db.Usuario.AsEnumerable()
                    .Where(x => x.registroActivo && x.usuario.Contains(parametro))
                    .ToList();
            }
        }

        public static List<paUsuarioListar_Result> listarPa(string parametro)
        {
            using (var db = new MinervaEntities())
            {
                return db.paUsuarioListar(parametro).ToList();
            }
        }
    }
}
