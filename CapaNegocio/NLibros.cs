using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NLibros
    {
        public static string Insertar(string isbn, string titulo, string lenguaje, string editorial, string publicacion, string genero,string disponibilidad, string comentarios, string autores, string edicion, DateTime fechaedicion,int npaginas, string materia, string subgenero, string ubicacion, string tag, string codigobarras, byte[] imagen)
        {
            DLibro Obj = new DLibro();
            Obj.ISBN = isbn;
            Obj.Titulo = titulo;
            Obj.Lenguaje = lenguaje;
            Obj.Editorial = editorial;
            Obj.Publicacion = publicacion;
            Obj.Genero = genero;
            Obj.Disponibilidad = disponibilidad;
            Obj.Comentarios = comentarios;
            Obj.Autores = autores;
            Obj.Edicion = edicion;
            Obj.FechaEdicion = fechaedicion;
            Obj.NPaginas = npaginas;
            Obj.Materia = materia;
            Obj.Subgenero = subgenero;
            Obj.Ubicacion = ubicacion;
            Obj.Tag = tag;
            Obj.CodigoBarras = codigobarras;
            Obj.Imagen = imagen;

            return Obj.Insertar(Obj);
            
        }

        public static string Editar(string isbn, string titulo, string lenguaje, string editorial, string publicacion, string genero,string disponibilidad, string comentarios, string autores, string edicion, DateTime fechaedicion,int npaginas, string materia, string subgenero, string ubicacion, string tag, string codigobarras, byte[] imagen)
        {
            DLibro Obj = new DLibro();
            Obj.ISBN = isbn;
            Obj.Titulo = titulo;
            Obj.Lenguaje = lenguaje;
            Obj.Editorial = editorial;
            Obj.Publicacion = publicacion;
            Obj.Genero = genero;
            Obj.Disponibilidad = disponibilidad;
            Obj.Comentarios = comentarios;
            Obj.Autores = autores;
            Obj.Edicion = edicion;
            Obj.FechaEdicion = fechaedicion;
            Obj.NPaginas = npaginas;
            Obj.Materia = materia;
            Obj.Subgenero = subgenero;
            Obj.Ubicacion = ubicacion;
            Obj.Tag = tag;
            Obj.CodigoBarras = codigobarras;
            Obj.Imagen = imagen;

            return Obj.Editar(Obj);

        }

        public static string Eliminar(string isbn)
        {
            DLibro Obj = new DLibro();
            Obj.ISBN = isbn;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DLibro().Mostrar();
        }


        public static DataTable BuscarISBN(string isbn)
        {
            DLibro Obj = new DLibro();
            Obj.ISBN = isbn;
            return Obj.BuscarISBN(Obj);
        }


        public static DataTable ExisteISBN(string isbn)
        {
            DLibro Obj = new DLibro();
            Obj.ISBN = isbn;
            return Obj.BuscarISBN(Obj);
        }
    }
}
