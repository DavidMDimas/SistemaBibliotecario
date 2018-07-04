using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAutor
    {

        private int _IdAutor;
        private string _Nombre;
        private string _Apellido;
        private string _Nacionalidad;
        private int _Telefono;
        private string _Direccion;
        private string _Email;

        public int IdAutor
        {
            get { return _IdAutor; }
            set { _IdAutor = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellidos
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public string Nacionalidad
        {
            get { return _Nacionalidad; }
            set { _Nacionalidad = value; }
        }
        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DAutor()
        {

        }

        public DAutor(int idautor, string nombre, string apellido, string nacionalidad, int telefono, string direccion, string email)
        {
            this.IdAutor = idautor;
            this.Nombre = nombre;
            this.Apellidos = apellido;
            this.Nacionalidad = nacionalidad;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Email = email;
        }

        public string Insertar(DAutor Autor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarAutor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdAutor = new SqlParameter();
                ParIdAutor.ParameterName = "@idAutor";
                ParIdAutor.SqlDbType = SqlDbType.Int;
                ParIdAutor.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdAutor);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Autor.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Autor.Apellidos;
                sqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParNacionlidad = new SqlParameter();
                ParNacionlidad.ParameterName = "@nacionalidad";
                ParNacionlidad.SqlDbType = SqlDbType.VarChar;
                ParNacionlidad.Size = 50;
                ParNacionlidad.Value = Autor.Nacionalidad;
                sqlCmd.Parameters.Add(ParNacionlidad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = Autor.Telefono;
                sqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Autor.Direccion;
                sqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Autor.Email;
                sqlCmd.Parameters.Add(ParEmail);
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

        public string Editar(DAutor Autor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPEditarAutor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdAutor = new SqlParameter();
                ParIdAutor.ParameterName = "@idAutor";
                ParIdAutor.SqlDbType = SqlDbType.Int;
                ParIdAutor.Value = Autor.IdAutor;
                sqlCmd.Parameters.Add(ParIdAutor);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Autor.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Autor.Apellidos;
                sqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParNacionlidad = new SqlParameter();
                ParNacionlidad.ParameterName = "@nacionalidad";
                ParNacionlidad.SqlDbType = SqlDbType.VarChar;
                ParNacionlidad.Size = 50;
                ParNacionlidad.Value = Autor.Nacionalidad;
                sqlCmd.Parameters.Add(ParNacionlidad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = Autor.Telefono;
                sqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Autor.Direccion;
                sqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Autor.Email;
                sqlCmd.Parameters.Add(ParEmail);
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

        public string Eliminar(DAutor Autor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarAutor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAutor = new SqlParameter();
                ParIdAutor.ParameterName = "@idAutor";
                ParIdAutor.SqlDbType = SqlDbType.VarChar;
                ParIdAutor.Value = Autor.IdAutor;
                SqlCmd.Parameters.Add(ParIdAutor);

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
            DataTable DtResultado = new DataTable("Autor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarAutor";
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


        public DataTable BuscarNombreCompleto(DAutor Autor)
        {
            DataTable DtResultado = new DataTable("Libros");
            SqlConnection SqlCon = new SqlConnection();
            try //CRUD Create, Read, Update, Deleted
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPBuscarNombreAutor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Autor.Nombre;
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

        public DataTable MostrarNombreCompleto()
        {
            DataTable DtResultado = new DataTable("Autor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarAutorNC";
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
    }
}
