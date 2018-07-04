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
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty)
                {
                    errorIcono.SetError(txtMatricula, "Ingrese matricula");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Guardar prestamo", "Autorizar prestamo", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        //NPrestamo.Insertar(txtMatricula.Text, txtcbTipoprestamo.Text, txtIsbn)
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
                dataListado.Rows.Add(txtIsbn.Text, txtNombreLibro.Text, txtEditorial.Text, txtAutor.Text);
                GetDataListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

                SqlCon.Close();

                EstatusUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();

            try
            {
                string SqlSelectQuery = "select titulo, editorial, autores from Libros WHERE isbn = " + (txtIsbn.Text);
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNombreLibro.Text = (dr["titulo"].ToString());
                    txtEditorial.Text = (dr["editorial"].ToString());
                    txtAutor.Text = (dr["autores"].ToString());
                }
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
            validaciones.solonumeros(e);
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
                    if (Convert.ToBoolean(fila.Cells["ColumnISBN"].Value))
                    {
                        txtObservaciones.Text = fila.Cells["ColumnISBN"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
