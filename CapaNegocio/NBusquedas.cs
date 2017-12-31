using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NBusquedas
    {
        public static DataTable BusquedasISBN(string isbn,DataTable dtLibros)
        {
            DBusquedas Obj = new DBusquedas();
            Obj.Isbn = isbn;

            List<DLibro> busquedas = new List<DLibro>();
            foreach (DataRow row in dtLibros.Rows)
            {
                DLibro busqueda = new DLibro();

                busqueda.IdLibro = Convert.ToInt32(row["IdLibro"].ToString());
                busqueda.ISBN = Convert.ToString(row["isbn"].ToString());
                busqueda.Titulo = Convert.ToString(row["titulo"].ToString());
                busqueda.Lenguaje = Convert.ToString(row["lenguaje"].ToString());
                busqueda.Editorial = Convert.ToString(row["editorial"].ToString());
                busqueda.Publicacion = Convert.ToString(row["publicacion"].ToString());
                busqueda.Genero = Convert.ToString(row["genero"].ToString());
                busqueda.Disponibilidad = Convert.ToString(row["disponibilidad"].ToString());
                busqueda.Comentarios = Convert.ToString(row["comentarios"].ToString());
                busqueda.Autores = Convert.ToString(row["autores"].ToString());
                busqueda.Edicion = Convert.ToString(row["edicion"].ToString());
                busqueda.FechaEdicion = Convert.ToDateTime(row["fechaedicion"].ToString());
                busqueda.NPaginas = Convert.ToInt32(row["npaginas"].ToString());
                busqueda.Materia = Convert.ToString(row["materia"].ToString());
                busqueda.Subgenero = Convert.ToString(row["subgenero"].ToString());
                busqueda.Ubicacion = Convert.ToString(row["ubicacion"].ToString());
                busqueda.Tag = Convert.ToString(row["tag"].ToString());
                busqueda.CodigoBarras = Convert.ToString(row["codigobarras"].ToString());

                //Recordar image

                busquedas.Add(busqueda);
            }

            return Obj.BusquedaISBN(Obj);
        }

        public static DataTable BusquedasTitulo(string titulo)
        {
            DBusquedas Obj = new DBusquedas();
            Obj.Titulo=titulo;

            return Obj.BusquedaTitulo(Obj);
        }

        public static DataTable BusquedasAutor(string autores)
        {
            DBusquedas Obj = new DBusquedas();
            Obj.Autores = autores;

            return Obj.BusquedaAutor(Obj);
        }
    }
}
