using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;

namespace Sistema_bibliotecario
{
    public partial class frmPrestamo : Form
    {
        DataTable dt;

        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void getDataLista()
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();
            try
            {
                string SqlSelectQuery = "select matricula, (nombre + apellidos) as 'Nombre Completo', carrera,  email from Usuarios WHERE matricula = " + (txtMatricula.Text);

                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtMatricula.Text = (dr["matricula"].ToString());
                    txtNombreCompleto.Text = (dr["Nombre Completo"].ToString());
                    txtCarrera.Text = (dr["carrera"].ToString());
                    txtEmail.Text = (dr["email"].ToString());
                }

                dr.Close();
                SqlCon.Close();

                EstatusUsuario();
                cuentaLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void cuentaLibros()
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;
            SqlCon.Open();
            string cuentaPrestamos;

            try {
                //string SqlSelectQuery = "select count(Matricula) as 'MAT' from Prestamos where Matricula='"+(txtMatricula.Text)+"';";
                /*string SqlSelectQuery = "select count(Matricula) as 'MAT' from Prestamos where Matricula='201322150';";
                SqlCommand sqlCmd = new SqlCommand(SqlSelectQuery, SqlCon);*/
                SqlCommand sqlCmd = SqlCon.CreateCommand();
                sqlCmd.CommandText = "select count(Matricula) as 'MAT' from Prestamos where Matricula=@Matricula";
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.Add(new SqlParameter("@Matricula", "201322150"));

                SqlDataReader dr = sqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    cuentaPrestamos = dr["MAT"] as string;
                    MessageBox.Show(cuentaPrestamos);
                }

                dr.Close();
                SqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty || txtIsbn.Text==string.Empty)
                {
                    errorIcono.SetError(txtMatricula, "Ingrese matricula");
                    errorIcono.SetError(txtIsbn, "Ingrese el ISBN");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Guardar prestamo", "Autorizar prestamo", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        NPrestamo.Insertar(txtMatricula.Text, txtcbTipoprestamo.Text, txtIsbn.Text,"","", txtdtFechaPrestamo.Value,
                            txtdtPrimerRenovacion.Value, txtdtSegundaRenovacion.Value,txtObservaciones.Text,"0");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int cuentaLibros;
                cuentaLibros = Convert.ToInt32(this.dataListado.Rows.Count.ToString());

                if (cuentaLibros<3) { 
                    dataListado.Rows.Add(txtIsbn.Text, txtNombreLibro.Text, txtEditorial.Text, txtAutor.Text);
                    GetDataListado();
                    //countBooks();
                }
                else
                {
                    MessageBox.Show("Limite excedido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            getDataLista();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();

            try
            {
                string SqlSelectQuery = "select isbn as 'ISBN',titulo AS 'TITULO', editorial AS 'EDITORIAL', autores AS 'AUTORES' from Libros where isbn='8461272447'";
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    /*txtIsbn.Text = (dr["isbn"].ToString());
                    txtNombreLibro.Text = (dr["titulo"].ToString());
                    txtEditorial.Text = (dr["editorial"].ToString());
                    txtAutor.Text = (dr["autores"].ToString());*/

                    foreach (DataGridViewRow fila in dataListado.Rows)
                    {
                        fila.Cells["ISBN"].Value = (dr["ISBN"].ToString());
                        fila.Cells["TITULO"].Value = (dr["TITULO"].ToString());
                        fila.Cells["EDITORIAL"].Value = (dr["EDITORIAL"].ToString());
                        fila.Cells["AUTORES"].Value = (dr["AUTORES"].ToString());
                    }
                 }

                dr.Close();
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }//8461272447
            }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validaciones.solonumeros(e);
        }

        private void EstatusUsuario()
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();

            try
            {
                string sqlQuery = "select Matricula, Estatus FROM Prestamos WHERE Matricula =" + txtMatricula.Text + "AND Estatus = '1'";

                SqlCommand command = new SqlCommand(sqlQuery, SqlCon);
                command.Parameters.AddWithValue("Matricula", txtMatricula.Text);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    lblEstatus.Text = "Aceptado";
                    lblEstatus.ForeColor = Color.LightGreen;
                    btnPrestamo.Enabled = true;
                }
                else
                {
                    lblEstatus.Text = "Rechazado";
                    lblEstatus.ForeColor = Color.Red;
                    btnPrestamo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resul = MessageBox.Show("Desea eliminar este libro", "Eliminar libro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    dataListado.Rows.Remove(dataListado.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void GetDataListado()
        {
            try
            {
                foreach(DataGridViewRow fila in dataListado.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells["isbn"].Value))
                    {
                        txtObservaciones.Text = fila.Cells["isbn"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnSancion_Click(object sender, EventArgs e)
        {
            frmSancionO frm = new frmSancionO();
            frm.txtMatriculaSancion.Text = txtMatricula.Text;
            frm.Show();
            this.Hide();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {

        }

        private bool Bloquear(bool status)
        {
            txtMatricula.Enabled = false;
            return status;
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
