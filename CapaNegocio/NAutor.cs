using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NAutor
    {
        public static string Insertar(string nombre, string apellido, string nacionalidad, int telefono, string direccion, string email)
        {
            DAutor Obj = new DAutor();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellido;
            Obj.Nacionalidad = nacionalidad;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Email = email;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int idautor, string nombre, string apellido, string nacionalidad, int telefono, string direccion, string email)
        {
            DAutor Obj = new DAutor();
            Obj.IdAutor = idautor;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellido;
            Obj.Nacionalidad = nacionalidad;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Email = email;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idautor)
        {
            DAutor Obj = new DAutor();
            Obj.IdAutor = idautor;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DAutor().Mostrar();
        }

        public static DataTable MostrarNombreCompleto()
        {
            return new DAutor().MostrarNombreCompleto();
        }

        public static DataTable BuscarNombreCompleto(string nombre)
        {
            DAutor Obj = new DAutor();
            Obj.Nombre = nombre;
            return Obj.BuscarNombreCompleto(Obj);
        }
    }
}
