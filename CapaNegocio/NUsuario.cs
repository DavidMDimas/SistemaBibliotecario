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
    public class NUsuario
    {
        public static string Insertar(string matricula, string nombre, string apellidos, string carrera, string sexo, string tipousuario, string email)
        {
            DUsuario Obj = new DUsuario();
            Obj.Matricula = matricula;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Carrera = carrera;
            Obj.Sexo = sexo;
            Obj.TipoUsuario = tipousuario;
            Obj.Email = email;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int idusuario, string matricula, string nombre, string apellidos, string carrera, string sexo, string tipousuario, string email)
        {
            DUsuario Obj = new DUsuario();
            Obj.IdUsuario = idusuario;
            Obj.Matricula = matricula;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Carrera = carrera;
            Obj.Sexo = sexo;
            Obj.TipoUsuario = tipousuario;
            Obj.Email = email;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(string matricula)
        {
            DUsuario Obj = new DUsuario();
            Obj.Matricula = matricula;

            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DUsuario().Mostrar();
        }

        public static DataTable BuscarMatricula(string matricula)
        {
            DUsuario Obj = new DUsuario();
            Obj.Matricula = matricula;

            return Obj.BuscarMatricula(Obj);
        }

        public static DataTable BuscarNombreCompleto(string nombre)
        {
            DUsuario Obj = new DUsuario();
            Obj.Nombre = nombre;

            return Obj.BuscarNombreCompleto(Obj);
        }
    }
}
