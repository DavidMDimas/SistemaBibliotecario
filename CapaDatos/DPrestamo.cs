using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPrestamo
    {
        private int _IdPrestamo;

        private string _Matricula;

        private string _TipoPrestamo;
        private string _ISBN;
        private string _ISBN2;
        private string _ISBN3;
        private DateTime _FechaPrestamo;
        private DateTime _PrimerRenovacion;
        private DateTime _SegundaRenovacion;
        private string _Observaciones;
        private string _Estatus;


        public int IdPrestamo
        {
            get { return _IdPrestamo; }
            set { _IdPrestamo = value; }
        }
        public string Matricula
        {
            get { return _Matricula; }
            set { _Matricula = value; }
        }
        public string TipoPrestamo
        {
            get { return _TipoPrestamo; }
            set { _TipoPrestamo = value; }
        }
        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }
        public string ISBN2
        {
            get { return _ISBN2; }
            set { _ISBN2 = value; }
        }
        public string ISBN3
        {
            get { return _ISBN3; }
            set { _ISBN3 = value; }
        }
        public DateTime FechaPrestamo
        {
            get { return _FechaPrestamo; }
            set { _FechaPrestamo = value; }
        }
        public DateTime PrimerRenovacion
        {
            get { return _PrimerRenovacion; }
            set { _PrimerRenovacion = value; }
        }
        public DateTime SegundaRenovacion
        {
            get { return _SegundaRenovacion; }
            set { _SegundaRenovacion = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }
        public string Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }

        public DPrestamo() { }

        public DPrestamo(int idprestamo, string matricula, string tipoprestamo, string isbn, string isbn2, string isbn3,
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
        }

        public string Insertar(DPrestamo Prestamo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarPrestamo";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdPrestamo = new SqlParameter();
                ParIdPrestamo.ParameterName = "@idPrestamo";
                ParIdPrestamo.SqlDbType = SqlDbType.Int;
                ParIdPrestamo.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdPrestamo);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Prestamo.Matricula;
                sqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParTipoprestamo = new SqlParameter();
                ParTipoprestamo.ParameterName = "@tipoprestamo";
                ParTipoprestamo.SqlDbType = SqlDbType.VarChar;
                ParTipoprestamo.Size = 50;
                ParTipoprestamo.Value = Prestamo.TipoPrestamo;
                sqlCmd.Parameters.Add(ParTipoprestamo);

                SqlParameter ParISBN = new SqlParameter();
                ParISBN.ParameterName = "@isbn";
                ParISBN.SqlDbType = SqlDbType.VarChar;
                ParISBN.Size = 50;
                ParISBN.Value = Prestamo.ISBN;
                sqlCmd.Parameters.Add(ParISBN);

                SqlParameter ParISBN2 = new SqlParameter();
                ParISBN2.ParameterName = "@isbn2";
                ParISBN2.SqlDbType = SqlDbType.VarChar;
                ParISBN2.Size = 50;
                ParISBN2.Value = Prestamo.ISBN2;
                sqlCmd.Parameters.Add(ParISBN2);

                SqlParameter ParISBN3 = new SqlParameter();
                ParISBN3.ParameterName = "@isbn3";
                ParISBN3.SqlDbType = SqlDbType.VarChar;
                ParISBN3.Size = 50;
                ParISBN3.Value = Prestamo.ISBN;
                sqlCmd.Parameters.Add(ParISBN3);

                SqlParameter ParFechaPrestamo = new SqlParameter();
                ParFechaPrestamo.ParameterName = "@fechaprestamo";
                ParFechaPrestamo.SqlDbType = SqlDbType.VarChar;
                ParFechaPrestamo.Size = 50;
                ParFechaPrestamo.Value = Prestamo.FechaPrestamo;
                sqlCmd.Parameters.Add(ParFechaPrestamo);

                SqlParameter ParPrimeraRenovacion = new SqlParameter();
                ParPrimeraRenovacion.ParameterName = "@primerrenovacion";
                ParPrimeraRenovacion.SqlDbType = SqlDbType.VarChar;
                ParPrimeraRenovacion.Size = 50;
                ParPrimeraRenovacion.Value = Prestamo.PrimerRenovacion;
                sqlCmd.Parameters.Add(ParPrimeraRenovacion);

                SqlParameter ParSegundaRenovacion = new SqlParameter();
                ParSegundaRenovacion.ParameterName = "@segundarenovacion";
                ParSegundaRenovacion.SqlDbType = SqlDbType.VarChar;
                ParSegundaRenovacion.Size = 50;
                ParSegundaRenovacion.Value = Prestamo.SegundaRenovacion;
                sqlCmd.Parameters.Add(ParSegundaRenovacion);

                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.VarChar;
                ParObservaciones.Size = 200;
                ParObservaciones.Value = Prestamo.Observaciones;
                sqlCmd.Parameters.Add(ParObservaciones);

                SqlParameter ParEstatus = new SqlParameter();
                ParEstatus.ParameterName = "@estatus";
                ParEstatus.SqlDbType = SqlDbType.VarChar;
                ParEstatus.Size = 50;
                ParEstatus.Value = Estatus;
                sqlCmd.Parameters.Add(ParEstatus);
                ///

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        public string Editar(DPrestamo Prestamo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPEditarPrestamo";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdPrestamo = new SqlParameter();
                ParIdPrestamo.ParameterName = "@idPrestamo";
                ParIdPrestamo.SqlDbType = SqlDbType.Int;
                ParIdPrestamo.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdPrestamo);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Prestamo.Matricula;
                sqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParTipoprestamo = new SqlParameter();
                ParTipoprestamo.ParameterName = "@tipoprestamo";
                ParTipoprestamo.SqlDbType = SqlDbType.VarChar;
                ParTipoprestamo.Size = 50;
                ParTipoprestamo.Value = Prestamo.TipoPrestamo;
                sqlCmd.Parameters.Add(ParTipoprestamo);

                SqlParameter ParISBN = new SqlParameter();
                ParISBN.ParameterName = "@isbn";
                ParISBN.SqlDbType = SqlDbType.VarChar;
                ParISBN.Size = 50;
                ParISBN.Value = Prestamo.ISBN;
                sqlCmd.Parameters.Add(ParISBN);

                SqlParameter ParISBN2 = new SqlParameter();
                ParISBN2.ParameterName = "@isbn2";
                ParISBN2.SqlDbType = SqlDbType.VarChar;
                ParISBN2.Size = 50;
                ParISBN2.Value = Prestamo.ISBN2;
                sqlCmd.Parameters.Add(ParISBN2);

                SqlParameter ParISBN3 = new SqlParameter();
                ParISBN3.ParameterName = "@isbn3";
                ParISBN3.SqlDbType = SqlDbType.VarChar;
                ParISBN3.Size = 50;
                ParISBN3.Value = Prestamo.ISBN;
                sqlCmd.Parameters.Add(ParISBN3);

                SqlParameter ParFechaPrestamo = new SqlParameter();
                ParFechaPrestamo.ParameterName = "@fechaprestamo";
                ParFechaPrestamo.SqlDbType = SqlDbType.VarChar;
                ParFechaPrestamo.Size = 50;
                ParFechaPrestamo.Value = Prestamo.FechaPrestamo;
                sqlCmd.Parameters.Add(ParFechaPrestamo);

                SqlParameter ParPrimeraRenovacion = new SqlParameter();
                ParPrimeraRenovacion.ParameterName = "@primerrenovacion";
                ParPrimeraRenovacion.SqlDbType = SqlDbType.VarChar;
                ParPrimeraRenovacion.Size = 50;
                ParPrimeraRenovacion.Value = Prestamo.PrimerRenovacion;
                sqlCmd.Parameters.Add(ParPrimeraRenovacion);

                SqlParameter ParSegundaRenovacion = new SqlParameter();
                ParSegundaRenovacion.ParameterName = "@segundarenovacion";
                ParSegundaRenovacion.SqlDbType = SqlDbType.VarChar;
                ParSegundaRenovacion.Size = 50;
                ParSegundaRenovacion.Value = Prestamo.SegundaRenovacion;
                sqlCmd.Parameters.Add(ParSegundaRenovacion);

                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.VarChar;
                ParObservaciones.Size = 200;
                ParObservaciones.Value = Prestamo.Observaciones;
                sqlCmd.Parameters.Add(ParObservaciones);

                SqlParameter ParEstatus = new SqlParameter();
                ParEstatus.ParameterName = "@estatus";
                ParEstatus.SqlDbType = SqlDbType.VarChar;
                ParEstatus.Size = 50;
                ParEstatus.Value = Estatus;
                sqlCmd.Parameters.Add(ParEstatus);
                ///

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se modifico el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Eliminar(DPrestamo Prestamo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarPrestamo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Value = Prestamo.Matricula;
                SqlCmd.Parameters.Add(ParMatricula);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //SPMostrarPrestamoMatricula 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Prestamos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarTodosPrestamos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable BuscarPrestamoMatricula(DPrestamo Prestamo)
        {
            DataTable DtResultado = new DataTable("Prestamo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarPrestamoMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscarMatricula = new SqlParameter();
                ParBuscarMatricula.ParameterName = "@matricula";
                ParBuscarMatricula.SqlDbType = SqlDbType.VarChar;
                ParBuscarMatricula.Size = 50;
                ParBuscarMatricula.Value = Prestamo.Matricula;
                SqlCmd.Parameters.Add(ParBuscarMatricula);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }
}
