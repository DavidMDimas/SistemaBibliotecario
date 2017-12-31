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
    public class NPrestamo
    {
        public static string Insertar(string matricula, string tipoprestamo, string isbn, string isbn2, string isbn3,
            DateTime fecha_prestamo, DateTime primer_renovacion, DateTime segunda_renovacion,
            string observaciones, string estatus)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.Matricula = matricula;
            Obj.TipoPrestamo = tipoprestamo;
            Obj.ISBN = isbn;
            Obj.ISBN2 = isbn2;
            Obj.ISBN3 = isbn3;
            Obj.FechaPrestamo = fecha_prestamo;
            Obj.PrimerRenovacion = primer_renovacion;
            Obj.SegundaRenovacion = segunda_renovacion;
            Obj.Observaciones = observaciones;
            Obj.Estatus = estatus;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int idprestamo, string matricula, string tipoprestamo, string isbn, string isbn2, string isbn3,
            DateTime fecha_prestamo, DateTime primer_renovacion, DateTime segunda_renovacion,
            string observaciones, string estatus)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.IdPrestamo = idprestamo;
            Obj.Matricula = matricula;
            Obj.TipoPrestamo = tipoprestamo;
            Obj.ISBN = isbn;
            Obj.ISBN2 = isbn2;
            Obj.ISBN3 = isbn3;
            Obj.FechaPrestamo = fecha_prestamo;
            Obj.PrimerRenovacion = primer_renovacion;
            Obj.SegundaRenovacion = segunda_renovacion;
            Obj.Observaciones = observaciones;
            Obj.Estatus = estatus;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(string matricula)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.Matricula = matricula;

            return Obj.Eliminar(Obj);
        }

        public static string EntregaLibros(string matricula)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.Matricula = matricula;

            return Obj.EntregaLibros(Obj);
        }

        public static string SancionarPrestamos(string matricula)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.Matricula = matricula;

            return Obj.SancionPrestamo(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPrestamo().Mostrar();
        }

        public static DataTable BuscarPrestamoMatricula(string matricula)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.Matricula = matricula;

            return Obj.BuscarPrestamoMatricula(Obj);
        }

        public static DataTable buscarAlumnoPrestamo(string matricula)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.Matricula = matricula;

            return Obj.BuscarAlumnoPrestamo(Obj);
        }

        public static DataTable MostrarLibrosPrestamoMat(string matricula)
        {
            DPrestamo Obj = new DPrestamo();
            Obj.Matricula = matricula;

            return Obj.BuscarLibrosPrestadosMatricula(Obj);
        }
    }
}
