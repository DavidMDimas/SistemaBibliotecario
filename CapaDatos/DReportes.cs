using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DReportes
    {
        private DateTime _fecha1;
        private DateTime _fecha2;

        public DateTime Fecha1
        {
            get { return _fecha1; }
            set { _fecha1 = value; }
        }

        public DateTime Fecha2
        {
            get { return _fecha2; }
            set { _fecha2 = value; }
        }

        public DReportes() {
        }

        public DReportes(DateTime fecha1,DateTime fecha2)
        {
            DReportes Obj = new DReportes();
            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;
        }

        public DataTable MostrarReporteAlumnoMasculino(DReportes Reportes)
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteAlumnosMasculinos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parFecha1 = new SqlParameter();
                parFecha1.ParameterName = "@fecha1";
                parFecha1.SqlDbType = SqlDbType.Date;
                parFecha1.Value = Reportes.Fecha1;
                sqlCmd.Parameters.Add(parFecha1);

                SqlParameter parFecha2 = new SqlParameter();
                parFecha2.ParameterName = "@fecha2";
                parFecha2.SqlDbType = SqlDbType.Date;
                parFecha2.Value = Reportes.Fecha2;
                sqlCmd.Parameters.Add(parFecha2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);

            }catch(Exception ex)
            {
                dtRes = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dtRes;
        }

        public DataTable MostrarReporteAlumnoFemenino(DReportes Reportes)
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteAlumnosFemeninos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parFecha1 = new SqlParameter();
                parFecha1.ParameterName = "@fecha1";
                parFecha1.SqlDbType = SqlDbType.Date;
                parFecha1.Value = Reportes.Fecha1;
                sqlCmd.Parameters.Add(parFecha1);

                SqlParameter parFecha2 = new SqlParameter();
                parFecha2.ParameterName = "@fecha2";
                parFecha2.SqlDbType = SqlDbType.Date;
                parFecha2.Value = Reportes.Fecha2;
                sqlCmd.Parameters.Add(parFecha2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);

            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dtRes;
        }

        public DataTable MostrarReporteProfesorMasculino(DReportes Reportes)
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteProfesoresMasculinos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parFecha1 = new SqlParameter();
                parFecha1.ParameterName = "@fecha1";
                parFecha1.SqlDbType = SqlDbType.Date;
                parFecha1.Value = Reportes.Fecha1;
                sqlCmd.Parameters.Add(parFecha1);

                SqlParameter parFecha2 = new SqlParameter();
                parFecha2.ParameterName = "@fecha2";
                parFecha2.SqlDbType = SqlDbType.Date;
                parFecha2.Value = Reportes.Fecha2;
                sqlCmd.Parameters.Add(parFecha2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);

            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dtRes;
        }

        public DataTable MostrarReporteProfesorFemenino(DReportes Reportes)
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteProfesoresFemeninos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parFecha1 = new SqlParameter();
                parFecha1.ParameterName = "@fecha1";
                parFecha1.SqlDbType = SqlDbType.Date;
                parFecha1.Value = Reportes.Fecha1;
                sqlCmd.Parameters.Add(parFecha1);

                SqlParameter parFecha2 = new SqlParameter();
                parFecha2.ParameterName = "@fecha2";
                parFecha2.SqlDbType = SqlDbType.Date;
                parFecha2.Value = Reportes.Fecha2;
                sqlCmd.Parameters.Add(parFecha2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);

            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dtRes;
        }

        public DataTable MostrarReporteAdministrativoMasculino(DReportes Reportes)
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteAdministrativosMasculinos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parFecha1 = new SqlParameter();
                parFecha1.ParameterName = "@fecha1";
                parFecha1.SqlDbType = SqlDbType.Date;
                parFecha1.Value = Reportes.Fecha1;
                sqlCmd.Parameters.Add(parFecha1);

                SqlParameter parFecha2 = new SqlParameter();
                parFecha2.ParameterName = "@fecha2";
                parFecha2.SqlDbType = SqlDbType.Date;
                parFecha2.Value = Reportes.Fecha2;
                sqlCmd.Parameters.Add(parFecha2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);

            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dtRes;
        }

        public DataTable MostrarReporteAdministrativoFemenino(DReportes Reportes)
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteAdministrativosFemeninos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parFecha1 = new SqlParameter();
                parFecha1.ParameterName = "@fecha1";
                parFecha1.SqlDbType = SqlDbType.Date;
                parFecha1.Value = Reportes.Fecha1;
                sqlCmd.Parameters.Add(parFecha1);

                SqlParameter parFecha2 = new SqlParameter();
                parFecha2.ParameterName = "@fecha2";
                parFecha2.SqlDbType = SqlDbType.Date;
                parFecha2.Value = Reportes.Fecha2;
                sqlCmd.Parameters.Add(parFecha2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);

            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dtRes;
        }

        public DataTable MostrarReporteLibrosTotales(DReportes Reportes)
        {
            DataTable dtRes = new DataTable("Libros");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteLibrosTotales";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parFecha1 = new SqlParameter();
                parFecha1.ParameterName = "@fecha1";
                parFecha1.SqlDbType = SqlDbType.Date;
                parFecha1.Value = Reportes.Fecha1;
                sqlCmd.Parameters.Add(parFecha1);

                SqlParameter parFecha2 = new SqlParameter();
                parFecha2.ParameterName = "@fecha2";
                parFecha2.SqlDbType = SqlDbType.Date;
                parFecha2.Value = Reportes.Fecha2;
                sqlCmd.Parameters.Add(parFecha2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);

            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return dtRes;
        }

        //*************************MOSTRAR TODOS SIN USAR FECHAS***********************

        public DataTable MostrarRLibrosGeneral()
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteLibrosGeneral";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtRes);
            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public DataTable MostrarRAlumnoMasculino()
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteGeneralAlumnosMasculino";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(dtRes);
            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public DataTable MostrarRAlumnoFemenino()
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteGeneralAlumnosFemenino";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(dtRes);
            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public DataTable MostrarRProfesorMasculino()
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteGeneralProfesorMasculino";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(dtRes);
            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public DataTable MostrarRProfesorFemenino()
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteGeneralProfesorFemenino";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(dtRes);
            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public DataTable MostrarRAdmMasculino()
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteGeneralAdministrativoMasculino";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(dtRes);
            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public DataTable MostrarRAdmFemenino()
        {
            DataTable dtRes = new DataTable("Usuarios");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "SPReporteGeneralAdministrativoFemenino";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(dtRes);
            }
            catch (Exception ex)
            {
                dtRes = null;
            }
            return dtRes;
        }
    }
}
