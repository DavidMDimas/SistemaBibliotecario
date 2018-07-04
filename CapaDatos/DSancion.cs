using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSancion
    {
        private int _IdAdeudo;
        private string _NombreAlumno;
        private string _ApellidoAlumno;
        private double _MontoaPagar;
        private DateTime _FechaUltimaRenovacion;

        public int IdAdeudo
        {
            get { return _IdAdeudo; }
            set { value = _IdAdeudo; }
        }
        public string NombreAlumno
        {
            get { return _NombreAlumno; }
            set { value = _NombreAlumno; }
        }

        public string ApellidoAlumno { get => _ApellidoAlumno; set => _ApellidoAlumno = value; }
        public double MontoaPagar { get => _MontoaPagar; set => _MontoaPagar = value; }
        public DateTime FechaUltimaRenovacion { get => _FechaUltimaRenovacion; set => _FechaUltimaRenovacion = value; }

        public DSancion() { }

        public DSancion(int idadeudo, string nombrealumno, string apellidoalumno, double montoapagar, DateTime fechaultimarenovacion)
        {
            DSancion Obj = new DSancion();
            Obj.IdAdeudo = idadeudo;
            Obj.NombreAlumno = nombrealumno;
            Obj.ApellidoAlumno = apellidoalumno;
            Obj.MontoaPagar = montoapagar;
            Obj.FechaUltimaRenovacion = fechaultimarenovacion;
        }

        public string Insertar(DSancion Sancion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarSancio";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///////////
                SqlParameter ParIdAdeudo = new SqlParameter();
                ParIdAdeudo.ParameterName = "@idadeudo";
                ParIdAdeudo.SqlDbType = SqlDbType.Int;
                ParIdAdeudo.Direction = ParameterDirection.Output;
                ParIdAdeudo.Value = Sancion.IdAdeudo;
                sqlCmd.Parameters.Add(ParIdAdeudo);

                SqlParameter ParNombreAlumno = new SqlParameter();
                ParNombreAlumno.ParameterName = "@nombrealumno";
                ParNombreAlumno.SqlDbType = SqlDbType.VarChar;
                ParNombreAlumno.Size = 50;
                ParNombreAlumno.Value = Sancion.NombreAlumno;
                sqlCmd.Parameters.Add(ParNombreAlumno);

                SqlParameter ParApellidoAlumno = new SqlParameter();
                ParApellidoAlumno.ParameterName = "@apellidoalumno";
                ParApellidoAlumno.SqlDbType = SqlDbType.VarChar;
                ParApellidoAlumno.Size = 50;
                ParApellidoAlumno.Value = Sancion.ApellidoAlumno;
                sqlCmd.Parameters.Add(ParApellidoAlumno);

                SqlParameter ParMontoPagar = new SqlParameter();
                ParMontoPagar.ParameterName = "@montopagar";
                ParMontoPagar.SqlDbType = SqlDbType.VarChar;
                ParMontoPagar.Size = 50;
                ParMontoPagar.Value = Sancion.MontoaPagar;
                sqlCmd.Parameters.Add(ParMontoPagar);

                SqlParameter ParFechaUltimaRenovacion = new SqlParameter();
                ParFechaUltimaRenovacion.ParameterName = "@ultimarenovacion";
                ParFechaUltimaRenovacion.SqlDbType = SqlDbType.Date;
                ParFechaUltimaRenovacion.Value = Sancion.FechaUltimaRenovacion;
                sqlCmd.Parameters.Add(ParFechaUltimaRenovacion);

                ////////////
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

    }
}
