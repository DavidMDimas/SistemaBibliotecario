using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class NSancion
    {

        public static string Insertar(string matricula,string nombre, string apellidos,string carrera,string turno,string grupo,string email, DateTime fecha, double pagofinal,int diasretraso, double montofinal)
        {
            DSancion Obj = new DSancion();

            Obj.MatriculaAl = matricula;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Carrera = carrera;
            Obj.Turno = turno;
            Obj.Grupo = grupo;
            Obj.Email = email;
            Obj.FechaPrestamo = fecha;
            Obj.PagoFinal = pagofinal;
            Obj.DiasRetraso = diasretraso;
            Obj.MontoFinal = montofinal;

            return Obj.Insertar(Obj);
        }

        public static string Modificar(int idsancion,string matricula,string nombre,string apellidos, string carrera, string turno,string grupo, string email,DateTime fecha, double pagofinal,int diasretraso, double montofinal)
        {
            DSancion Obj = new DSancion();

            Obj.IdSancion = idsancion;
            Obj.MatriculaAl = matricula;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Carrera = carrera;
            Obj.Turno = turno;
            Obj.Grupo = grupo;
            Obj.Email = email;
            Obj.FechaPrestamo = fecha;
            Obj.PagoFinal = pagofinal;
            Obj.DiasRetraso = diasretraso;
            Obj.MontoFinal = montofinal;

            return Obj.Modificar(Obj);
        }

        public static string Eliminar(int idsancion)
        {
            DSancion Obj = new DSancion();
            Obj.IdSancion = idsancion;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DSancion().Mostrar();
        }

        public static DataTable BuscarSancionesPorMatricula(string matricula)
        {
            DSancion Obj = new DSancion();
            Obj.MatriculaAl = matricula;
            return Obj.BusquedaPorMatricula(Obj);
        }

    }
}
