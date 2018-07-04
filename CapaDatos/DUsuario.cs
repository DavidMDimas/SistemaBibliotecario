using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario
    {
        private int _IdUsuario;
        private string _Matricula;
        private string _Nombre;
        private string _Apellidos;
        private string _Carrera;
        private string _Sexo;
        private string _TipoUsuario;
        private string _Email;
        private DateTime _fechaIngreso;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
        public string Matricula
        {
            get { return _Matricula; }
            set { _Matricula = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        public string Carrera
        {
            get { return _Carrera; }
            set { _Carrera = value; }
        }
        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }
        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { _TipoUsuario = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }

        public DUsuario() { }

        public DUsuario(int idusuario, string matricula, string nombre, string apellidos, string carrera, string sexo, string tipousuario, string email,DateTime fechaingreso)
        {
            this.IdUsuario = idusuario;
            this.Matricula = matricula;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Carrera = carrera;
            this.Sexo = sexo;
            this.TipoUsuario = tipousuario;
            this.Email = email;
            this.FechaIngreso = fechaingreso;
        }

        public string Insertar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarUsuario";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdUsuario = new SqlParameter();
                ParIdUsuario.ParameterName = "@idusuario";
                ParIdUsuario.SqlDbType = SqlDbType.Int;
                ParIdUsuario.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdUsuario);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Usuario.Matricula;
                sqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Usuario.Apellidos;
                sqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParCarrera = new SqlParameter();
                ParCarrera.ParameterName = "@carrera";
                ParCarrera.SqlDbType = SqlDbType.VarChar;
                ParCarrera.Size = 50;
                ParCarrera.Value = Usuario.Carrera;
                sqlCmd.Parameters.Add(ParCarrera);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Usuario.Sexo;
                sqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParTipoUsuario = new SqlParameter();
                ParTipoUsuario.ParameterName = "@tipousuario";
                ParTipoUsuario.SqlDbType = SqlDbType.VarChar;
                ParTipoUsuario.Size = 50;
                ParTipoUsuario.Value = Usuario.TipoUsuario;
                sqlCmd.Parameters.Add(ParTipoUsuario);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Usuario.Email;
                sqlCmd.Parameters.Add(ParEmail);
                
                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Usuario.FechaIngreso;
                sqlCmd.Parameters.Add(ParFecha);

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

        public string Editar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPEditarUsuario";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdUsuario = new SqlParameter();
                ParIdUsuario.ParameterName = "@idusuario";
                ParIdUsuario.SqlDbType = SqlDbType.Int;
                ParIdUsuario.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdUsuario);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Usuario.Matricula;
                sqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Usuario.Apellidos;
                sqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParCarrera = new SqlParameter();
                ParCarrera.ParameterName = "@carrera";
                ParCarrera.SqlDbType = SqlDbType.VarChar;
                ParCarrera.Size = 50;
                ParCarrera.Value = Usuario.Carrera;
                sqlCmd.Parameters.Add(ParCarrera);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Usuario.Sexo;
                sqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParTipoUsuario = new SqlParameter();
                ParTipoUsuario.ParameterName = "@tipousuario";
                ParTipoUsuario.SqlDbType = SqlDbType.VarChar;
                ParTipoUsuario.Size = 50;
                ParTipoUsuario.Value = Usuario.TipoUsuario;
                sqlCmd.Parameters.Add(ParTipoUsuario);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Usuario.Email;
                sqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Usuario.FechaIngreso;
                sqlCmd.Parameters.Add(ParFecha);

                ///

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se modifico el Registro";

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


        public string Eliminar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Value = Usuario.Matricula;
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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarUsuarios";
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


        public DataTable BuscarMatricula(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Usuario.Matricula;
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


        public DataTable BuscarNombreCompleto(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarNombreUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

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
