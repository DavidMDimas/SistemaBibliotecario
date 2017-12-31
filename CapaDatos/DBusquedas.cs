using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DBusquedas
    {
        private string _isbn;
        private string _titulo;
        private string _autores;

        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Autores
        {
            get { return _autores; }
            set { _autores = value; }
        }

        public DBusquedas() { }

        public DBusquedas(string isbn,string titulo,string autores)
        {
            DBusquedas Obj = new DBusquedas();

            Obj.Isbn = isbn;
            Obj.Titulo = titulo;
            Obj.Autores = autores;
        }

        public DataTable BusquedaISBN(DBusquedas Busquedas)
        {
            DataTable DTRes = new DataTable("Libros");
            SqlConnection SqlCon = new SqlConnection();
            string rpta = "";

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.Transaction = SqlTra;
                sqlCmd.CommandText = "SPBusquedasISBN";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParISBN = new SqlParameter();
                ParISBN.ParameterName = "@isbn";
                ParISBN.SqlDbType = SqlDbType.VarChar;
                ParISBN.Size = 50;
                ParISBN.Value = Busquedas.Isbn;
                sqlCmd.Parameters.Add(ParISBN);

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(DTRes);

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                
                /*
                if (rpta.Equals("OK"))
                {
                    //Obtener el ISBN del libro buscado
                    this.Isbn = Convert.ToString(sqlCmd.Parameters["@isbn"].Value);

                    foreach (DLibro bus in libroL)
                    {
                        bus.ISBN = this.Isbn;
                        rpta = bus.BuscarISBN(bus);
                    }
                }*/

            }
            catch(Exception ex)
            {
                DTRes = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DTRes;
        }

        public DataTable BusquedaTitulo(DBusquedas Busquedas)
        {
            DataTable DTRes = new DataTable("Libros");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPBusquedasTitulo";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 50;
                ParTitulo.Value = Busquedas.Titulo;
                sqlCmd.Parameters.Add(ParTitulo);

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(DTRes);

            }
            catch (Exception ex)
            {
                DTRes = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DTRes;
        }

        public DataTable BusquedaAutor(DBusquedas Busquedas)
        {
            DataTable DTRes = new DataTable("Libros");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPBusquedasAutor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAutor = new SqlParameter();
                ParAutor.ParameterName = "@autores";
                ParAutor.SqlDbType = SqlDbType.VarChar;
                ParAutor.Size = 50;
                ParAutor.Value = Busquedas.Autores;
                sqlCmd.Parameters.Add(ParAutor);

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlCmd);
                SqlDat.Fill(DTRes);

            }
            catch (Exception ex)
            {
                DTRes = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DTRes;
        }

    }
}
