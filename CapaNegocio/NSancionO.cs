using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
namespace CapaNegocio
{
    public class NSancionO
    {
        public static string Insertar(string matricula, string isbn, int idprestamo, string numreferencia, DateTime fechaprestamo, int dias, double montofinal,string estatus)
        {
            DSancionO Obj = new DSancionO();
            
            Obj.MatriculaAl = matricula;
            Obj.Isbn = isbn;
            Obj.IdPrestamo = idprestamo;
            Obj.NumReferencia = numreferencia;
            Obj.FechaPrestamo = fechaprestamo;
            Obj.Dias = dias;
            Obj.TotalPago = montofinal;
            Obj.Estatus = estatus;

            return Obj.Insertar(Obj);
        }

        public static string Modificar(int id_sancion,string matricula, string isbn, int idprestamo, string numreferencia, DateTime fechaprestamo, int dias, double montofinal,string estatus)
        {
            DSancionO Obj = new DSancionO();

            Obj.IdSancion = id_sancion;
            Obj.MatriculaAl = matricula;
            Obj.Isbn = isbn;
            Obj.IdPrestamo = idprestamo;
            Obj.NumReferencia = numreferencia;
            Obj.FechaPrestamo = fechaprestamo;
            Obj.Dias = dias;
            Obj.TotalPago = montofinal;
            Obj.Estatus = estatus;

            return Obj.Modificar(Obj);
        }

        public static string Eliminar(int id_sancion)
        {
            DSancionO Obj = new DSancionO();

            Obj.IdSancion = id_sancion;

            return Obj.Eliminar(Obj);
        }

        public static DataTable MostrarSO()
        {
            return new DSancionO().MostrarSO();
        }

        public static DataTable BuscarSancionMatricula(string matricula)
        {
            DSancionO Obj = new DSancionO();
            Obj.MatriculaAl = matricula;
            return Obj.BuscarSancionMatricula(Obj);
        }

        public static DataTable MostrarSancionesGeneralM(string matricula)
        {
            DSancionO Obj = new DSancionO();
            Obj.MatriculaAl = matricula;
            return Obj.MostrarSancionesGeneralMatricula(Obj);
        }
        

    }
}
