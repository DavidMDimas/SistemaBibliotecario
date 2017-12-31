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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";
            this.txtEmail.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty)
                {

                    errorIcono.SetError(txtNombre, "Ingrese un dato");
                    errorIcono.SetError(txtApellido, "Ingrese un dato");

                }
                else
                {

                    //Convert.ToInt32(txtTelefono.Text)
                    NAutor.Insertar(this.txtNombre.Text.ToUpper(), this.txtApellido.Text.ToUpper(), "",
                       Convert.ToInt32(txtTelefono.Text), this.txtDireccion.Text, this.txtEmail.Text);
                    MessageBox.Show("Registro guardado");
                    Limpiar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty)
                {

                    errorIcono.SetError(txtNombre, "Ingrese un dato");
                    errorIcono.SetError(txtApellido, "Ingrese un dato");

                }
                else
                {
                    DialogResult resul = MessageBox.Show("Realmente desea modificar el registro", "Modificar registro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        NAutor.Editar(Convert.ToInt32(txtIdAutor.Text), this.txtNombre.Text.ToUpper(), this.txtApellido.Text.ToUpper(), "",
                            Convert.ToInt32(txtTelefono.Text), this.txtDireccion.Text, this.txtEmail.Text);
                        MessageBox.Show("Registro Modificado");
                        Limpiar();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdAutor.Text == string.Empty)
                {
                    errorIcono.SetError(txtIdAutor, "Debe seleccionar un autor");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Realmente desea eliminar el registro. ?", "Eliminar registro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        NAutor.Eliminar(Convert.ToInt32(txtIdAutor.Text));
                        MessageBox.Show("Registro eliminado");
                        Limpiar();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAutor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idAutor"].Value);
            txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido"].Value);
            txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Telefono"].Value);
            txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Direccion"].Value);
            txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Email"].Value);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataListado.DataSource = NAutor.BuscarNombreCompleto(this.txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
