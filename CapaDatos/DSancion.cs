using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSancion
    {
        private int _idSancion;
        private string _matricula;
        private string _nombre;
        private string _apellidos;
        private string _carrera;
        private string _turno;
        private string _grupo;
        private string _email;
        private DateTime _fechaPrestamo;
        private double _pagoFinal;
        private int _diasRetraso;
        private double _montoFinal;
        //aqui añade los libros que se lleva
        //ISBN -> Libro, Autor, Editorial
        //Tambien la referencia de pago
        /*
         * private int _IdSancion
         * _Matricula
         * _ISBN
         * _IdPrestamo
         * Numero de referencia
         * Fecha prestamo
         * Dias
         * Total a pagar
         * 
         * Cuando se mande llamar la matricula se carga el query que auto llene los textbox pero unicamente se alamcena matricula o id de usuario
         * igual en libro, unicamente se almacena el isbn pero cuando se mande llamar se cargan los datos del libro
         * para ello hacemos una consulta anidada.
         * Como consejo, tus tipos de datos que sean varchar y no nvarchar.
         * 
         * Intenta que la interfaz utilice los controles que te envie en la captura, porque si saturamos de controles el form,es mucho trabajo para el usuario
         * 
         * Pero bien :D verdad que es facil n-capas siii :3 gracias por los consejos
         * 
         * utiliza ahora unicamente esos datos que estan arriba, es lo unico que se almacenara, para que no elimines estos modulos,dejalos y crea otro  que EhagaN rteferencia 

            vale :D entendido ya me pondre a terminarlos asi
            Si, usa los datos que te doy arriba, pero en un nuevo modulo, para que se vea pro y como si estuviera relacionada la db
            claro bro, gracias 
            Vale, nos daran unos sensores y tendremos que rediseñar la db se cero, pero para no hacerlo, por eso es irla adaptando
            ya no seria tan complejo teniendo esto ya diseñado C:
         * */

        public int IdSancion
        {
            get { return _idSancion; }
            set { _idSancion=value; }
        }

        public string MatriculaAl
        {
            get { return _matricula; }
            set {  _matricula=value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre=value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos=value; }
        }

        public string Carrera
        {
            get { return _carrera; }
            set { _carrera=value; }
        }

        public string Turno
        {
            get { return _turno; }
            set {  _turno=value; }
        }

        public string Grupo
        {
            get { return _grupo; }
            set { _grupo=value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email=value; }
        }

        public DateTime FechaPrestamo
        {
            get { return _fechaPrestamo; }
            set { _fechaPrestamo=value; }
        }

        public double PagoFinal
        {
            get { return _pagoFinal; }
            set { _pagoFinal= value; }
        }

        public int DiasRetraso
        {
            get { return _diasRetraso; }
            set { _diasRetraso = value; }
        }

        public double MontoFinal
        {
            get { return _montoFinal; }
            set { _montoFinal = value; }
        }

        public DSancion() { }

        public DSancion(int idsancion,string matricula, string nombre, string apellidos, string carrera,string turno,string grupo,string email, DateTime fechaprestamo, double pagof,int diasretraso, double montofinal)
        {
            DSancion Obj = new DSancion();
            Obj.IdSancion = idsancion;
            Obj.MatriculaAl = matricula;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Carrera = carrera;
            Obj.Turno = turno;
            Obj.Grupo = grupo;
            Obj.Email = email;
            Obj.FechaPrestamo = fechaprestamo;
            Obj.PagoFinal = pagof;
            Obj.DiasRetraso = diasretraso;
            Obj.MontoFinal = montofinal;
        }


        //Insercion
        public string Insertar(DSancion Sancion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = SqlCon;
                sqlCmd.CommandText = "SPInsertarSancion";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                ///////////*****************************************////////////////
                SqlParameter ParIdSancion = new SqlParameter();
                ParIdSancion.ParameterName = "@id_sancion";
                ParIdSancion.SqlDbType = SqlDbType.Int;
                ParIdSancion.Direction = ParameterDirection.Output;
                ParIdSancion.Value = Sancion.IdSancion;
                sqlCmd.Parameters.Add(ParIdSancion);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Sancion.MatriculaAl;
                sqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Sancion.Nombre;
                sqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellidos";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Sancion.Apellidos;
                sqlCmd.Parameters.Add(ParApellido); //***********

                SqlParameter ParCarrera = new SqlParameter();
                ParCarrera.ParameterName = "@carrera";
                ParCarrera.SqlDbType = SqlDbType.VarChar;
                ParCarrera.Size = 50;
                ParCarrera.Value = Sancion.Carrera;
                sqlCmd.Parameters.Add(ParCarrera);

                SqlParameter ParTurno = new SqlParameter();
                ParTurno.ParameterName = "@turno";
                ParTurno.SqlDbType = SqlDbType.VarChar;
                ParTurno.Size = 50;
                ParTurno.Value = Sancion.Turno;
                sqlCmd.Parameters.Add(ParTurno);

                SqlParameter ParGrupo = new SqlParameter();
                ParGrupo.ParameterName = "@grupo";
                ParGrupo.SqlDbType = SqlDbType.VarChar;
                ParGrupo.Size = 50;
                ParGrupo.Value = Sancion.Grupo;
                sqlCmd.Parameters.Add(ParGrupo);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Sancion.Email;
                sqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParFecha= new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 50;
                ParFecha.Value = Sancion.FechaPrestamo;
                sqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParPagoFinal = new SqlParameter();
                ParPagoFinal.ParameterName = "@pagofinal";
                ParPagoFinal.SqlDbType = SqlDbType.Float;
                ParPagoFinal.Value = Sancion.PagoFinal;
                sqlCmd.Parameters.Add(ParPagoFinal);

                SqlParameter ParDiasRetraso = new SqlParameter();
                ParDiasRetraso.ParameterName = "@diasretraso";
                ParDiasRetraso.SqlDbType = SqlDbType.Int;
                ParDiasRetraso.Value = Sancion.DiasRetraso;
                sqlCmd.Parameters.Add(ParDiasRetraso);

                SqlParameter ParMontoFinal = new SqlParameter();
                ParMontoFinal.ParameterName = "@montofinal";
                ParMontoFinal.SqlDbType = SqlDbType.Float;
                ParMontoFinal.Value = Sancion.MontoFinal;
                sqlCmd.Parameters.Add(ParMontoFinal);

                ///******************************************///
                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "Registro modificado" : "Registro no modificado";

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

        public string Modificar(DSancion Sancion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEditarSancion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //************************************////////
                SqlParameter ParIdSancion = new SqlParameter();
                ParIdSancion.ParameterName = "@id_sancion";
                ParIdSancion.SqlDbType = SqlDbType.VarChar;
                ParIdSancion.Value = Sancion.IdSancion;
                SqlCmd.Parameters.Add(ParIdSancion);

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Sancion.MatriculaAl;
                SqlCmd.Parameters.Add(ParMatricula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Sancion.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellidos";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Sancion.Apellidos;
                SqlCmd.Parameters.Add(ParApellido); 

                SqlParameter ParCarrera = new SqlParameter();
                ParCarrera.ParameterName = "@carrera";
                ParCarrera.SqlDbType = SqlDbType.VarChar;
                ParCarrera.Size = 50;
                ParCarrera.Value = Sancion.Carrera;
                SqlCmd.Parameters.Add(ParCarrera);

                SqlParameter ParTurno = new SqlParameter();
                ParTurno.ParameterName = "@turno";
                ParTurno.SqlDbType = SqlDbType.VarChar;
                ParTurno.Size = 50;
                ParTurno.Value = Sancion.Turno;
                SqlCmd.Parameters.Add(ParTurno);

                SqlParameter ParGrupo = new SqlParameter();
                ParGrupo.ParameterName = "@grupo";
                ParGrupo.SqlDbType = SqlDbType.VarChar;
                ParGrupo.Size = 50;
                ParGrupo.Value = Sancion.Grupo;
                SqlCmd.Parameters.Add(ParGrupo);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Sancion.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 50;
                ParFecha.Value = Sancion.FechaPrestamo;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParPagoFinal = new SqlParameter();
                ParPagoFinal.ParameterName = "@pagofinal";
                ParPagoFinal.SqlDbType = SqlDbType.Float;
                ParPagoFinal.Value = Sancion.PagoFinal;
                SqlCmd.Parameters.Add(ParPagoFinal);

                SqlParameter ParDiasRetraso = new SqlParameter();
                ParDiasRetraso.ParameterName = "@diasretraso";
                ParDiasRetraso.SqlDbType = SqlDbType.Int;
                ParDiasRetraso.Value = Sancion.DiasRetraso;
                SqlCmd.Parameters.Add(ParDiasRetraso);

                SqlParameter ParMontoFinal = new SqlParameter();
                ParMontoFinal.ParameterName = "@montofinal";
                ParMontoFinal.SqlDbType = SqlDbType.Float;
                ParMontoFinal.Value = Sancion.MontoFinal;
                SqlCmd.Parameters.Add(ParMontoFinal);

                ///******************************************///
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro correcto" : "Registro incorrecto";

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

        public string Eliminar(DSancion Sancion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPEliminarSancion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdSancion = new SqlParameter();
                ParIdSancion.ParameterName = "@idsancion";
                ParIdSancion.SqlDbType = SqlDbType.VarChar;
                ParIdSancion.Value = Sancion.IdSancion;
                SqlCmd.Parameters.Add(ParIdSancion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Registro eliminado" : "Registro no eliminado";
            }
            catch(Exception ex)
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
            DataTable DtResultado = new DataTable("Sancion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPMostrarSancion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable BusquedaPorMatricula(DSancion Sancion)
        {
            DataTable DtResultado = new DataTable("Sancion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPBuscarSancionMatricula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMatricula = new SqlParameter();
                ParMatricula.ParameterName = "@matricula";
                ParMatricula.SqlDbType = SqlDbType.VarChar;
                ParMatricula.Size = 50;
                ParMatricula.Value = Sancion.MatriculaAl;
                SqlCmd.Parameters.Add(ParMatricula);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
         }

    }
}
