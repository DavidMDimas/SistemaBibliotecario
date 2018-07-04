using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DEditorial
    {
        private int _IdEditorial;
        private string _Editorial;
        private string _TipoEditor;
        private string _Anioalta;

        public int IdEditorial
        {
            get { return _IdEditorial; }
            set { _IdEditorial = value; }
        }
        public string Editorial
        {
            get { return _Editorial; }
            set { _Editorial = value; }
        }
        public string TipoEditor
        {
            get { return _TipoEditor; }
            set { _TipoEditor = value; }
        }
        public string AnioAlta
        {
            get { return _Anioalta; }
            set { _Anioalta = value; }
        }

        public DEditorial()
        {

        }
        public DEditorial(int ideditorial, string editorial, string tipoeditor, string anioalta)
        {
            this.IdEditorial = ideditorial;
            this.Editorial = editorial;
            this.TipoEditor = tipoeditor;
            this.AnioAlta = anioalta;
        }

        public string Insertar(DEditorial Editoriales)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarEditorial";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEditorial = new SqlParameter();
                ParIdEditorial.ParameterName = "@ideditorial";
                ParIdEditorial.SqlDbType = SqlDbType.Int;
                ParIdEditorial.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdEditorial);

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 50;
                ParEditorial.Value = Editoriales.Editorial;
                sqlCmd.Parameters.Add(ParEditorial);

                SqlParameter ParTipoEditor = new SqlParameter();
                ParTipoEditor.ParameterName = "@tipoeditor";
                ParTipoEditor.SqlDbType = SqlDbType.VarChar;
                ParTipoEditor.Size = 50;
                ParTipoEditor.Value = Editoriales.TipoEditor;
                sqlCmd.Parameters.Add(ParTipoEditor);

                SqlParameter ParAnioRegistro = new SqlParameter();
                ParAnioRegistro.ParameterName = "@anioalta";
                ParAnioRegistro.SqlDbType = SqlDbType.VarChar;
                ParAnioRegistro.Size = 50;
                ParAnioRegistro.Value = Editoriales.AnioAlta;
                sqlCmd.Parameters.Add(ParAnioRegistro);


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


        public string Editar(DEditorial Editoriale)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPEditarEditorial";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEditorial = new SqlParameter();
                ParIdEditorial.ParameterName = "@ideditorial";
                ParIdEditorial.SqlDbType = SqlDbType.Int;
                ParIdEditorial.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdEditorial);

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 50;
                ParEditorial.Value = Editoriale.Editorial;
                sqlCmd.Parameters.Add(ParEditorial);

                SqlParameter ParTipoEditor = new SqlParameter();
                ParTipoEditor.ParameterName = "@tipoeditor";
                ParTipoEditor.SqlDbType = SqlDbType.VarChar;
                ParTipoEditor.Size = 50;
                ParTipoEditor.Value = Editoriale.TipoEditor;
                sqlCmd.Parameters.Add(ParTipoEditor);

                SqlParameter ParAnioRegistro = new SqlParameter();
                ParAnioRegistro.ParameterName = "@anioalta";
                ParAnioRegistro.SqlDbType = SqlDbType.VarChar;
                ParAnioRegistro.Size = 50;
                ParAnioRegistro.Value = Editoriale.AnioAlta;
                sqlCmd.Parameters.Add(ParAnioRegistro);


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

        public string Eliminar(DEditorial Editoriales)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarEditorial";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParidEditorial = new SqlParameter();
                ParidEditorial.ParameterName = "@ideditorial";
                ParidEditorial.SqlDbType = SqlDbType.Int;
                ParidEditorial.Value = Editoriales.IdEditorial;
                SqlCmd.Parameters.Add(ParidEditorial);

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
            DataTable DtResultado = new DataTable("Editoriales");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarEditoriales";
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


        public DataTable BuscarNombreEditorial(DEditorial Editoriales)
        {
            DataTable DtResultado = new DataTable("Editoriales");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPBuscarEditorial";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 50;
                ParEditorial.Value = Editoriales.Editorial;
                SqlCmd.Parameters.Add(ParEditorial);

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
