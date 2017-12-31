using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NEditorial
    {
        public static string Insertar(string editorial, string tipoeditor, string anioalta)
        {
            DEditorial Obj = new DEditorial();
            Obj.Editorial = editorial;
            Obj.TipoEditor = tipoeditor;
            Obj.AnioAlta = anioalta;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int ideditorial, string editorial, string tipoeditor, string anioalta)
        {
            DEditorial Obj = new DEditorial();
            Obj.IdEditorial = ideditorial;
            Obj.Editorial = editorial;
            Obj.TipoEditor = tipoeditor;
            Obj.AnioAlta = anioalta;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int ideditorial)
        {
            DEditorial Obj = new DEditorial();
            Obj.IdEditorial = ideditorial;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DEditorial().Mostrar();
        }

        public static DataTable BuscarEditorial(string editorial)
        {
            DEditorial Obj = new DEditorial();
            Obj.Editorial = editorial;
            return Obj.BuscarNombreEditorial(Obj);
        }
    }
}
