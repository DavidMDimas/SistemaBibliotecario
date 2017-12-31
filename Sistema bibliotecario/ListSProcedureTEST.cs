using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_bibliotecario
{

    

    public partial class ListSProcedureTEST : Form
    {
        public ListSProcedureTEST()
        {
            InitializeComponent();
        }

        public class Personas
        {
            public string Nombre
            {
                get; set;
            }
            public string Apellidos
            {
                get; set;
            }

            public int Edad
            {
                get; set;
            }

        };

        public IEnumerable<T> EjecutarStoredProcedure<T>(SqlParameter[] parameters, Func<SqlDataReader, T> body)
        {
            List<T> results = new List<T>();

            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.Cn;
            SqlCon.Open();

            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "SPBuscarAlumnoPrestamo";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            //Procedimiento creado YA SPBuscarAlumnoPrestamo
            //string SqlSelectQuery = "select IdUsuario,matricula,nombre,apellidos, carrera,  email from Usuarios WHERE matricula = " + (txtMatricula.Text);
            
            SqlDataReader dr = SqlCmd.ExecuteReader();


            SqlCmd.Parameters.AddRange(parameters);
            SqlDataReader reader = SqlCmd.ExecuteReader();
            while (reader.Read())
            {
                results.Add(body(reader));
            }
            reader.Close();
            
            return results;
        }

        /*
        public IEnumerable<string> GetUser()
        {
            try
            {
                return ProceduresExecution.Instance.EjecutarStoredProcedure<string>("SPBuscarAlumnoPrestamo",
                    GlobalData.ConnectionStringDefault,
                    new SqlParameter[]{
                new SqlParameter("@matricula", "201421448")
                    },
                    reader =>
                    {
                        return new string;
                        {
       
                    UserId = (string)reader["matricula"]
        
                            UserTypeId = (int)reader["UserTypeId"]
                        };
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario" + ex.message);
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();
            try
            {
                //Procedimiento creado YA SPBuscarAlumnoPrestamo
                //**********************************************ANALIZAR *********************************
                string SqlSelectQuery = "select IdUsuario,matricula,nombre,apellidos, carrera,  email from Usuarios WHERE matricula = " + (textBox1.Text);

                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    /*textBox2.Text = (dr["nombre"].ToString());
                    textBox3.Text = (dr["apellidos"].ToString());*/

                    //List<int> gente = new List<int>() {1,2,3,4};
                    
                    List<Personas> gente = new List<Personas>();
                    gente.Add(new Personas() { Nombre = (dr["nombre"].ToString()), Apellidos = (dr["apellidos"].ToString()),Edad=21 });

                    foreach (Personas g in gente)
                    {
                        label1.Text = Convert.ToString(g.Nombre);
                        textBox2.Text = g.Nombre;
                        textBox3.Text = g.Apellidos;
                        textBox4.Text = Convert.ToString(g.Edad);
                    }
                    
                for(int i=0;i<gente.Count;i++){
                    Personas g = gente[i];

                }

                    //label1.Text = Convert.ToString(g);
                    
                }




                dr.Close();
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public static List<Personas> GenteNueva()
        {
            List<Personas> gente = new List<Personas>();
            gente.Add(new Personas() { Nombre = "Juanito", Apellidos = "GreenPanther" });

            return gente;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();
            try
            {
                //Procedimiento creado YA SPBuscarAlumnoPrestamo
                //**********************************************ANALIZAR *********************************
                string SqlSelectQuery = "select IdUsuario,matricula,nombre,apellidos, carrera,  email from Usuarios WHERE matricula = " + (textBox1.Text);

                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    /*textBox2.Text = (dr["nombre"].ToString());
                    textBox3.Text = (dr["apellidos"].ToString());*/
                    /*
                    gente.Add(new Personas() { Nombre = (dr["nombre"].ToString()), Apellidos = (dr["apellidos"].ToString()) });

                    foreach (Personas g in gente)
                    {
                        label1.Text = Convert.ToString(g.Nombre);
                        textBox2.Text = g.Nombre;
                        textBox3.Text = g.Apellidos;
                    }
                    
                for(int i=0;i<
                    Personas g = gente[i];

                    //label1.Text = Convert.ToString(g);
                    */
                }

                dr.Close();
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //label1.Text = GenteNueva();
        }
    }
}
