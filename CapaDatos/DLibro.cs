using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DLibro
    {
        private int _IdLibro;
        private string _ISBN;
        private string _Titulo;
        private string _Lenguaje;
        private string _Editorial;
        private string _Publicacion;
        private string _Genero;
        private string _Disponibilidad;
        private string _Comentarios;
        private string _Autores;
        private string _Edicion;
        private DateTime _FechaEdicion;
        private int _NPaginas;
        private string _Materia;
        private string _Subgenero;
        private string _Ubicacion;
        private string _Tag;
        private string _CodigoBarras;
        private byte[] _Imagen;


        public int IdLibro
        {
            get { return _IdLibro; }
            set { _IdLibro = value; }
        }

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }
        public string Lenguaje
        {
            get { return _Lenguaje; }
            set { _Lenguaje = value; }
        }
        public string Editorial
        {
            get { return _Editorial; }
            set { _Editorial = value; }
        }
        public string Publicacion
        {
            get { return _Publicacion; }
            set { _Publicacion = value; }
        }
        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }
        public string Disponibilidad
        {
            get { return _Disponibilidad; }
            set { _Disponibilidad = value; }
        }
        public string Comentarios
        {
            get { return _Comentarios; }
            set { _Comentarios = value; }
        }
        public string Autores
        {
            get { return _Autores; }
            set { _Autores = value; }
        }
        public string Edicion
        {
            get { return _Edicion; }
            set { _Edicion = value; }
        }
        public DateTime FechaEdicion
        {
            get { return _FechaEdicion; }
            set { _FechaEdicion = value; }
        }
        public int NPaginas
        {
            get { return _NPaginas; }
            set { _NPaginas = value; }
        }
        public string Materia
        {
            get { return _Materia; }
            set { _Materia = value; }
        }
        public string Subgenero
        {
            get { return _Subgenero; }
            set { _Subgenero = value; }
        }
        public string Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }
        public string Tag
        {
            get { return _Tag; }
            set { _Tag = value; }
        }
        public string CodigoBarras
        {
            get { return _CodigoBarras; }
            set { _CodigoBarras = value; }
        }
        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        public DLibro()
        {

        }

        public DLibro(int idlibro, string isbn, string titulo, string lenguaje, string editorial, string publicacion, string genero,string disponibilidad, string comentarios, string autores, string edicion, DateTime fechaedicion,int npaginas, string materia, string subgenero, string ubicacion, string tag, string codigobarras, byte[] imagen)
        {
            this.IdLibro = idlibro;
            this.ISBN = isbn;
            this.Titulo = titulo;
            this.Lenguaje = lenguaje;
            this.Editorial = editorial;
            this.Publicacion = publicacion;
            this.Genero = genero;
            this.Disponibilidad = disponibilidad;
            this.Comentarios = comentarios;
            this.Autores = autores;
            this.Edicion = edicion;
            this.FechaEdicion = fechaedicion;
            this.NPaginas = npaginas;
            this.Materia = materia;
            this.Subgenero = subgenero;
            this.Ubicacion = ubicacion;
            this.Tag = tag;
            this.CodigoBarras = codigobarras;
            this.Imagen = imagen;
        }

        public string Insertar(DLibro Libro)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarLibro";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdLibro = new SqlParameter();
                ParIdLibro.ParameterName = "@idlibro";
                ParIdLibro.SqlDbType = SqlDbType.Int;
                ParIdLibro.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(ParIdLibro);

                SqlParameter ParIsbn = new SqlParameter();
                ParIsbn.ParameterName = "@isbn";
                ParIsbn.SqlDbType = SqlDbType.VarChar;
                ParIsbn.Size = 50;
                ParIsbn.Value = Libro.ISBN;
                sqlCmd.Parameters.Add(ParIsbn);

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 50;
                ParTitulo.Value = Libro.Titulo;
                sqlCmd.Parameters.Add(ParTitulo);

                SqlParameter ParLenguaje = new SqlParameter();
                ParLenguaje.ParameterName = "@lenguaje";
                ParLenguaje.SqlDbType = SqlDbType.VarChar;
                ParLenguaje.Size = 50;
                ParLenguaje.Value = Libro.Lenguaje;
                sqlCmd.Parameters.Add(ParLenguaje);

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 50;
                ParEditorial.Value = Libro.Editorial;
                sqlCmd.Parameters.Add(ParEditorial);

                SqlParameter ParPublicacion = new SqlParameter();
                ParPublicacion.ParameterName = "@publicacion";
                ParPublicacion.SqlDbType = SqlDbType.VarChar;
                ParPublicacion.Size = 50;
                ParPublicacion.Value = Libro.Publicacion;
                sqlCmd.Parameters.Add(ParPublicacion);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 50;
                ParGenero.Value = Libro.Genero;
                sqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParDisponibilidad = new SqlParameter();
                ParDisponibilidad.ParameterName = "@disponibilidad";
                ParDisponibilidad.SqlDbType = SqlDbType.VarChar;
                ParDisponibilidad.Size = 50;
                ParDisponibilidad.Value = Libro.Disponibilidad;
                sqlCmd.Parameters.Add(ParDisponibilidad);

                SqlParameter ParComentarios = new SqlParameter();
                ParComentarios.ParameterName = "@comentarios";
                ParComentarios.SqlDbType = SqlDbType.VarChar;
                ParComentarios.Size = 50;
                ParComentarios.Value = Libro.Comentarios;
                sqlCmd.Parameters.Add(ParComentarios);

                SqlParameter ParAutores = new SqlParameter();
                ParAutores.ParameterName = "@autores";
                ParAutores.SqlDbType = SqlDbType.VarChar;
                ParAutores.Size = 50;
                ParAutores.Value = Libro.Autores;
                sqlCmd.Parameters.Add(ParAutores);

                SqlParameter ParEdicion = new SqlParameter();
                ParEdicion.ParameterName = "@edicion";
                ParEdicion.SqlDbType = SqlDbType.VarChar;
                ParEdicion.Size = 50;
                ParEdicion.Value = Libro.Edicion;
                sqlCmd.Parameters.Add(ParEdicion);

                SqlParameter ParFechaEdicion = new SqlParameter();
                ParFechaEdicion.ParameterName = "@fechaedicion";
                ParFechaEdicion.SqlDbType = SqlDbType.Date;
                ParFechaEdicion.Value = Libro.FechaEdicion;
                sqlCmd.Parameters.Add(ParFechaEdicion);

                SqlParameter ParNPaginas = new SqlParameter();
                ParNPaginas.ParameterName = "@npaginas";
                ParNPaginas.SqlDbType = SqlDbType.Int;
                ParNPaginas.Value = Libro.NPaginas;
                sqlCmd.Parameters.Add(ParNPaginas);

                SqlParameter ParMateria = new SqlParameter();
                ParMateria.ParameterName = "@materia";
                ParMateria.SqlDbType = SqlDbType.VarChar;
                ParMateria.Size = 50;
                ParMateria.Value = Libro.Materia;
                sqlCmd.Parameters.Add(ParMateria);

                SqlParameter ParSubgenero = new SqlParameter();
                ParSubgenero.ParameterName = "@subgenero";
                ParSubgenero.SqlDbType = SqlDbType.VarChar;
                ParSubgenero.Size = 50;
                ParSubgenero.Value = Libro.Subgenero;
                sqlCmd.Parameters.Add(ParSubgenero);

                SqlParameter ParUbicacion = new SqlParameter();
                ParUbicacion.ParameterName = "@ubicacion";
                ParUbicacion.SqlDbType = SqlDbType.VarChar;
                ParUbicacion.Size = 50;
                ParUbicacion.Value = Libro.Ubicacion;
                sqlCmd.Parameters.Add(ParUbicacion);

                SqlParameter ParTag = new SqlParameter();
                ParTag.ParameterName = "@tag";
                ParTag.SqlDbType = SqlDbType.VarChar;
                ParTag.Size = 50;
                ParTag.Value = Libro.Tag;
                sqlCmd.Parameters.Add(ParTag);

                SqlParameter ParCodigoBarras = new SqlParameter();
                ParCodigoBarras.ParameterName = "@codigobarras";
                ParCodigoBarras.SqlDbType = SqlDbType.VarChar;
                ParCodigoBarras.Size = 50;
                ParCodigoBarras.Value = Libro.CodigoBarras;
                sqlCmd.Parameters.Add(ParCodigoBarras);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Libro.Imagen;
                sqlCmd.Parameters.Add(ParImagen);

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


        public string Editar(DLibro Libro)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPEditarLibro";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///
                SqlParameter ParIdLibro = new SqlParameter();
                ParIdLibro.ParameterName = "@idlibro";
                ParIdLibro.SqlDbType = SqlDbType.Int;
                ParIdLibro.Value = Libro.IdLibro;
                sqlCmd.Parameters.Add(ParIdLibro);

                SqlParameter ParIsbn = new SqlParameter();
                ParIsbn.ParameterName = "@isbn";
                ParIsbn.SqlDbType = SqlDbType.VarChar;
                ParIsbn.Size = 50;
                ParIsbn.Value = Libro.ISBN;
                sqlCmd.Parameters.Add(ParIsbn);

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 50;
                ParTitulo.Value = Libro.Titulo;
                sqlCmd.Parameters.Add(ParTitulo);

                SqlParameter ParLenguaje = new SqlParameter();
                ParLenguaje.ParameterName = "@lenguaje";
                ParLenguaje.SqlDbType = SqlDbType.VarChar;
                ParLenguaje.Size = 50;
                ParLenguaje.Value = Libro.Lenguaje;
                sqlCmd.Parameters.Add(ParLenguaje);

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 50;
                ParEditorial.Value = Libro.Editorial;
                sqlCmd.Parameters.Add(ParEditorial);

                SqlParameter ParPublicacion = new SqlParameter();
                ParPublicacion.ParameterName = "@publicacion";
                ParPublicacion.SqlDbType = SqlDbType.VarChar;
                ParPublicacion.Size = 50;
                ParPublicacion.Value = Libro.Publicacion;
                sqlCmd.Parameters.Add(ParPublicacion);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 50;
                ParGenero.Value = Libro.Genero;
                sqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParDisponibilidad = new SqlParameter();
                ParDisponibilidad.ParameterName = "@disponibilidad";
                ParDisponibilidad.SqlDbType = SqlDbType.VarChar;
                ParDisponibilidad.Size = 50;
                ParDisponibilidad.Value = Libro.Disponibilidad;
                sqlCmd.Parameters.Add(ParDisponibilidad);

                SqlParameter ParComentarios = new SqlParameter();
                ParComentarios.ParameterName = "@comentarios";
                ParComentarios.SqlDbType = SqlDbType.VarChar;
                ParComentarios.Size = 50;
                ParComentarios.Value = Libro.Comentarios;
                sqlCmd.Parameters.Add(ParComentarios);

                SqlParameter ParAutores = new SqlParameter();
                ParAutores.ParameterName = "@autores";
                ParAutores.SqlDbType = SqlDbType.VarChar;
                ParAutores.Size = 50;
                ParAutores.Value = Libro.Autores;
                sqlCmd.Parameters.Add(ParAutores);

                SqlParameter ParEdicion = new SqlParameter();
                ParEdicion.ParameterName = "@edicion";
                ParEdicion.SqlDbType = SqlDbType.VarChar;
                ParEdicion.Size = 50;
                ParEdicion.Value = Libro.Edicion;
                sqlCmd.Parameters.Add(ParEdicion);

                SqlParameter ParFechaEdicion = new SqlParameter();
                ParFechaEdicion.ParameterName = "@fechaedicion";
                ParFechaEdicion.SqlDbType = SqlDbType.Date;
                ParFechaEdicion.Value = Libro.FechaEdicion;
                sqlCmd.Parameters.Add(ParFechaEdicion);

                SqlParameter ParNPaginas = new SqlParameter();
                ParNPaginas.ParameterName = "@npaginas";
                ParNPaginas.SqlDbType = SqlDbType.Int;
                ParNPaginas.Value = Libro.NPaginas;
                sqlCmd.Parameters.Add(ParNPaginas);

                SqlParameter ParMateria = new SqlParameter();
                ParMateria.ParameterName = "@materia";
                ParMateria.SqlDbType = SqlDbType.VarChar;
                ParMateria.Size = 50;
                ParMateria.Value = Libro.Materia;
                sqlCmd.Parameters.Add(ParMateria);

                SqlParameter ParSubgenero = new SqlParameter();
                ParSubgenero.ParameterName = "@subgenero";
                ParSubgenero.SqlDbType = SqlDbType.VarChar;
                ParSubgenero.Size = 50;
                ParSubgenero.Value = Libro.Subgenero;
                sqlCmd.Parameters.Add(ParSubgenero);

                SqlParameter ParUbicacion = new SqlParameter();
                ParUbicacion.ParameterName = "@ubicacion";
                ParUbicacion.SqlDbType = SqlDbType.VarChar;
                ParUbicacion.Size = 50;
                ParUbicacion.Value = Libro.Ubicacion;
                sqlCmd.Parameters.Add(ParUbicacion);

                SqlParameter ParTag = new SqlParameter();
                ParTag.ParameterName = "@tag";
                ParTag.SqlDbType = SqlDbType.VarChar;
                ParTag.Size = 50;
                ParTag.Value = Libro.Tag;
                sqlCmd.Parameters.Add(ParTag);

                SqlParameter ParCodigoBarras = new SqlParameter();
                ParCodigoBarras.ParameterName = "@codigobarras";
                ParCodigoBarras.SqlDbType = SqlDbType.VarChar;
                ParCodigoBarras.Size = 50;
                ParCodigoBarras.Value = Libro.CodigoBarras;
                sqlCmd.Parameters.Add(ParCodigoBarras);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Libro.Imagen;
                sqlCmd.Parameters.Add(ParImagen);

                ///

                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se elimino el registro";

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

        public string Eliminar(DLibro Libro)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
               
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
           
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarLibro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParISBN = new SqlParameter();
                ParISBN.ParameterName = "@isbn";
                ParISBN.SqlDbType = SqlDbType.VarChar;
                ParISBN.Value = Libro.ISBN;
                SqlCmd.Parameters.Add(ParISBN);

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
            DataTable DtResultado = new DataTable("Libros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarLibros";
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

        public DataTable BuscarISBN(DLibro Libro)
        {
            DataTable DtResultado = new DataTable("Libros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPBuscarISBN";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscarISBN = new SqlParameter();
                ParBuscarISBN.ParameterName = "@isbn";
                ParBuscarISBN.SqlDbType = SqlDbType.VarChar;
                ParBuscarISBN.Size = 50;
                ParBuscarISBN.Value = Libro.ISBN;
                SqlCmd.Parameters.Add(ParBuscarISBN);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable ExisteISBN(DLibro Libro)
        {
            DataTable DtResultado = new DataTable("Libros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPExisteISBN";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscarISBN = new SqlParameter();
                ParBuscarISBN.ParameterName = "@isbn";
                ParBuscarISBN.SqlDbType = SqlDbType.VarChar;
                ParBuscarISBN.Size = 50;
                ParBuscarISBN.Value = Libro.ISBN;
                SqlCmd.Parameters.Add(ParBuscarISBN);

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
