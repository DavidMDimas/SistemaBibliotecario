using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DSancionO
    {
        private int _idSancion;
        private string _matricula;
        private string _isbn;
        private int _idPrestamo;
        private string _numReferencia;
        private DateTime _fechaPrestamo;
        private int _dias;
        private double _totalPago;
        private string _estatus;

        public int IdSancion
        {
            get { return _idSancion; }
            set { _idSancion = value; }
        }

        public string MatriculaAl
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int IdPrestamo
        {
            get { return _idPrestamo; }
            set { _idPrestamo = value; }
        }

        public string NumReferencia
        {
            get { return _numReferencia; }
            set { _numReferencia = value; }
        }

        public DateTime FechaPrestamo
        {
            get { return _fechaPrestamo; }
            set { _fechaPrestamo = value; }
        }

        public int Dias
        {
            get { return _dias; }
            set { _dias = value; }
        }

        public double TotalPago
        {
            get { return _totalPago; }
            set { _totalPago = value; }
        }

        public string Estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        public DSancionO() { }

        public DSancionO(int idsancion, string matricula, string isbn,int idprestamo,string numreferencia,DateTime fechaprestamo,int dias, double montofinal,string estatus)
        {
            /*
            DSancionO Obj = new DSancionO();
            Obj.IdSancion = idsancion;
            Obj.MatriculaAl = matricula;
            Obj.Isbn = isbn;
            Obj.IdPrestamo = idprestamo;
            Obj.NumReferencia = numreferencia;
            Obj.FechaPrestamo = fechaprestamo;
            Obj.Dias = dias;
            Obj.TotalPago = montofinal;
            Obj.Estatus = estatus;*/
            this.IdSancion = idsancion;
            this.MatriculaAl = matricula;
            this.Isbn = isbn;
            this.IdPrestamo = idprestamo;
            this.NumReferencia = numreferencia;
            this.FechaPrestamo = fechaprestamo;
            this.Dias = dias;
            this.TotalPago = montofinal;
            this.Estatus = estatus;
        }
        
        public string Insertar(DSancionO SancionO)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarSancionO";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///////////*****************************************////////////////
                SqlParameter ParIdSancion = new SqlParameter();
                ParIdSancion.ParameterName = "@id_sancion";
                ParIdSancion.SqlDbType = SqlDbType.Int;
                ParIdSancion.Direction = ParameterDirection.Output;
                ParIdSancion.Value = SancionO.IdSancion;
                sqlCmd.Parameters.Add(ParIdSancion);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = SancionO.MatriculaAl;
                sqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParIsbn = new SqlParameter();
                ParIsbn.ParameterName = "@isbn";
                ParIsbn.SqlDbType = SqlDbType.VarChar;
                ParIsbn.Size = 50;
                ParIsbn.Value = SancionO.Isbn;
                sqlCmd.Parameters.Add(ParIsbn);

                SqlParameter ParIdPrestamo = new SqlParameter();
                ParIdPrestamo.ParameterName = "@id_prestamo";
                ParIdPrestamo.SqlDbType = SqlDbType.VarChar;
                ParIdPrestamo.Size = 50;
                ParIdPrestamo.Value = SancionO.IdPrestamo;
                sqlCmd.Parameters.Add(ParIdPrestamo); //***********

                SqlParameter ParNumReferencia = new SqlParameter();
                ParNumReferencia.ParameterName = "@num_referencia";
                ParNumReferencia.SqlDbType = SqlDbType.VarChar;
                ParNumReferencia.Size = 50;
                ParNumReferencia.Value = SancionO.NumReferencia;
                sqlCmd.Parameters.Add(ParNumReferencia);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                //ParFecha.Size = 50;
                ParFecha.Value = SancionO.FechaPrestamo;
                sqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDias = new SqlParameter();
                ParDias.ParameterName = "@diasretraso";
                ParDias.SqlDbType = SqlDbType.Int;
                ParDias.Value = SancionO.Dias;
                sqlCmd.Parameters.Add(ParDias);

                SqlParameter ParMonto = new SqlParameter();
                ParMonto.ParameterName = "@montofinal";
                ParMonto.SqlDbType = SqlDbType.Float;
                ParMonto.Value = SancionO.TotalPago;
                sqlCmd.Parameters.Add(ParMonto);

                SqlParameter ParEstatus = new SqlParameter();
                ParEstatus.ParameterName = "@estatus";
                ParEstatus.SqlDbType = SqlDbType.VarChar;
                ParEstatus.Size = 50;
                ParEstatus.Value = SancionO.Estatus;
                sqlCmd.Parameters.Add(ParEstatus);

                ///////---------------------

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "Registro insertado" : "Registro no insertado";
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

        public string Modificar(DSancionO SancionO)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPModificarSancionO";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///////////////////////////
                SqlParameter ParIdSancion = new SqlParameter();
                ParIdSancion.ParameterName = "@id_sancion";
                ParIdSancion.SqlDbType = SqlDbType.VarChar;
                ParIdSancion.Value = SancionO.IdSancion;
                sqlCmd.Parameters.Add(ParIdSancion);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = SancionO.MatriculaAl;
                sqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParIsbn = new SqlParameter();
                ParIsbn.ParameterName = "@isbn";
                ParIsbn.SqlDbType = SqlDbType.VarChar;
                ParIsbn.Size = 50;
                ParIsbn.Value = SancionO.Isbn;
                sqlCmd.Parameters.Add(ParIsbn);

                SqlParameter ParIdPrestamo = new SqlParameter();
                ParIdPrestamo.ParameterName = "@id_prestamo";
                ParIdPrestamo.SqlDbType = SqlDbType.VarChar;
                ParIdPrestamo.Size = 50;
                ParIdPrestamo.Value = SancionO.IdPrestamo;
                sqlCmd.Parameters.Add(ParIdPrestamo); //***********

                SqlParameter ParNumReferencia = new SqlParameter();
                ParNumReferencia.ParameterName = "@num_referencia";
                ParNumReferencia.SqlDbType = SqlDbType.VarChar;
                ParNumReferencia.Size = 50;
                ParNumReferencia.Value = SancionO.NumReferencia;
                sqlCmd.Parameters.Add(ParNumReferencia);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = SancionO.FechaPrestamo;
                sqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDias = new SqlParameter();
                ParDias.ParameterName = "@diasretraso";
                ParDias.SqlDbType = SqlDbType.Int;
                ParDias.Value = SancionO.Dias;
                sqlCmd.Parameters.Add(ParDias);

                SqlParameter ParMonto = new SqlParameter();
                ParMonto.ParameterName = "@montofinal";
                ParMonto.SqlDbType = SqlDbType.Float;
                ParMonto.Value = SancionO.TotalPago;
                sqlCmd.Parameters.Add(ParMonto);

                SqlParameter ParEstatus = new SqlParameter();
                ParEstatus.ParameterName = "@estatus";
                ParEstatus.SqlDbType = SqlDbType.VarChar;
                ParEstatus.Size = 50;
                ParEstatus.Value = SancionO.Estatus;
                sqlCmd.Parameters.Add(ParEstatus);


                ///////---------------------

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "Registro modificado" : "Registro no modificado";
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

        public string Eliminar(DSancionO SancionO)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarSancionO";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdSancion = new SqlParameter();
                ParIdSancion.ParameterName = "@id_sancion";
                ParIdSancion.SqlDbType = SqlDbType.VarChar;
                ParIdSancion.Value = SancionO.IdSancion;
                SqlCmd.Parameters.Add(ParIdSancion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro eliminado" : "Registro no eliminado";
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

        public DataTable BuscarSancionMatricula(DSancionO SancionO)
        {
            DataTable DtResultado = new DataTable("Libros,Prestamos,Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarSancionMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Value = SancionO.MatriculaAl;
                SqlCmd.Parameters.Add(ParMatricula);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable MostrarSO()
        {
            DataTable DtResultado = new DataTable("SancionO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarSancionO";
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

        public DataTable MostrarSancionesGeneralMatricula(DSancionO SancionO)
        {
            DataTable DtResultado = new DataTable("SancionO");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarSancionGeneralM";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Value = SancionO.MatriculaAl;
                SqlCmd.Parameters.Add(ParMatricula);

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
