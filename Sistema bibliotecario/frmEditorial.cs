using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace Sistema_bibliotecario
{
    public partial class frmEditorial : Form
    {
        public frmEditorial()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtBuscar.Text = "";
            txtIdEditorial.Text = "";
            txtEditorial.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtEditorial.Text == string.Empty)
                {
                    errorIcono.SetError(txtEditorial, "Ingrese un dato");
                }
                else
                {
                    /* SqlCommand cmd = new SqlCommand("SPInsertarEditorial", SqlCon);
                     cmd.CommandType = CommandType.StoredProcedure;

                     cmd.Parameters.Add("@ideditorial", SqlDbType.Int).Value = Convert.ToInt32(txtIdEditorial.Text);
                     cmd.Parameters.Add("@editorial", SqlDbType.VarChar).Value = txtEditorial.Text;
                     cmd.Parameters.Add("@tipoeditor", SqlDbType.VarChar).Value = txtTipoEditor.Text;
                     cmd.Parameters.Add("@anioalta", SqlDbType.VarChar).Value = txtdtAnioalta.Text;


                     cmd.ExecuteNonQuery();

     */
                    NEditorial.Insertar(this.txtEditorial.Text.ToUpper(), txtTipoEditor.Text, txtdtAnioalta.Text);
                    MessageBox.Show("Registro guardado");
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();

            try
            {
                if (txtEditorial.Text == string.Empty)
                {
                    errorIcono.SetError(txtEditorial, "Ingrese un dato");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Realmente desea modificar el registro. ?", "Modificar registro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {

                        SqlCommand cmd = new SqlCommand("SPEditarEditorial", SqlCon);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ideditorial", SqlDbType.Int).Value = Convert.ToInt32(txtIdEditorial.Text);
                        cmd.Parameters.Add("@editorial", SqlDbType.VarChar).Value = txtEditorial.Text;
                        cmd.Parameters.Add("@tipoeditor", SqlDbType.VarChar).Value = txtTipoEditor.Text;
                        cmd.Parameters.Add("@anioalta", SqlDbType.VarChar).Value = txtdtAnioalta.Text;


                        cmd.ExecuteNonQuery();

                    }
                    //NEditorial.Editar(Convert.ToInt32(txtIdEditorial.Text), this.txtEditorial.Text.ToUpper(), txtTipoEditor.Text, txtdtAnioalta.Text);
                    MessageBox.Show("Registro modificado");
                    Limpiar();
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
                DialogResult resul = MessageBox.Show("Realmente desea eliminar el registro.?", "Eliminar registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    NEditorial.Eliminar(Convert.ToInt32(txtIdEditorial.Text));
                    MessageBox.Show("Registro eliminado");
                    Limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {


                this.dataListado.DataSource = NEditorial.BuscarEditorial(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEditorial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IdEditorial"].Value);
            txtEditorial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Editorial"].Value);
            txtTipoEditor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["TipoEditor"].Value);
            txtdtAnioalta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["AnioAlta"].Value);
        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {

        }
    }
}
