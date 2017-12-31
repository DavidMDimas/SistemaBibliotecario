using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NReportes
    {

        public static DataTable AlumnosMasculinos(DateTime fecha1,DateTime fecha2)
        {
            DReportes Obj = new DReportes();

            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;

            return Obj.MostrarReporteAlumnoMasculino(Obj);
        }

        public static DataTable AlumnosFemeninos(DateTime fecha1, DateTime fecha2)
        {
            DReportes Obj = new DReportes();

            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;

            return Obj.MostrarReporteAlumnoFemenino(Obj);
        }

        public static DataTable ProfesoresMasculinos(DateTime fecha1, DateTime fecha2)
        {
            DReportes Obj = new DReportes();

            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;

            return Obj.MostrarReporteProfesorMasculino(Obj);
        }

        public static DataTable ProfesoresFemeninos(DateTime fecha1, DateTime fecha2)
        {
            DReportes Obj = new DReportes();

            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;

            return Obj.MostrarReporteProfesorFemenino(Obj);
        }

        public static DataTable AdministrativosMasculinos(DateTime fecha1, DateTime fecha2)
        {
            DReportes Obj = new DReportes();

            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;

            return Obj.MostrarReporteAdministrativoMasculino(Obj);
        }

        public static DataTable AdministrativosFemeninos(DateTime fecha1, DateTime fecha2)
        {
            DReportes Obj = new DReportes();

            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;

            return Obj.MostrarReporteAdministrativoFemenino(Obj);
        }

        public static DataTable LibrosTotales(DateTime fecha1, DateTime fecha2)
        {
            DReportes Obj = new DReportes();

            Obj.Fecha1 = fecha1;
            Obj.Fecha2 = fecha2;

            return Obj.MostrarReporteLibrosTotales(Obj);
        }

        //Mostrar todos sin fecha

        public static DataTable MostrarLibrosGeneral()
        {
            return new DReportes().MostrarRLibrosGeneral();
        }

        public static DataTable MostrarAlumnoMasculinoGeneral()
        {
            return new DReportes().MostrarRAlumnoMasculino();
        }

        public static DataTable MostrarAlumnoFemeninoGeneral()
        {
            return new DReportes().MostrarRAlumnoFemenino();
        }

        public static DataTable MostrarProfesorMasculinoGeneral()
        {
            return new DReportes().MostrarRProfesorMasculino();
        }

        public static DataTable MostrarProfesorFemeninoGeneral()
        {
            return new DReportes().MostrarRProfesorFemenino();
        }

        public static DataTable MostrarAdmMasculinoGeneral()
        {
            return new DReportes().MostrarRAdmMasculino();
        }

        public static DataTable MostrarAdmFemeninoGeneral()
        {
            return new DReportes().MostrarRAdmFemenino();
        }
    }
}
