using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NSancion
    {
        public static string Insertar(string nombrealumno, string apellidoalumno, double montoapagar, DateTime fechaultimarenovacion)
        {
            DSancion Obj = new DSancion();
            Obj.NombreAlumno = nombrealumno;
            Obj.ApellidoAlumno = apellidoalumno;
            Obj.MontoaPagar = montoapagar;
            Obj.FechaUltimaRenovacion = fechaultimarenovacion;

            return Obj.Insertar(Obj);
        }
    }
}
