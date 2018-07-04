using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_bibliotecario
{
    class Conexion
    {
        
        public static string Cn = Properties.Settings.Default.cn;
        public static string ConexionDB = Properties.Settings.Default.conexion;

            /*
        public static string Cn = "Data Source=192.168.1.110,1433;Initial Catalog=SistemaBibliotecarioDB;Persist Security Info=True;User ID=tesi;Password=12345678";
        public static string ConexionDB = "Data Source=192.168.1.110,1433;Initial Catalog=SistemaBibliotecaDBGeneral;User ID=tesi;Password=12345678";*/
    }
}
