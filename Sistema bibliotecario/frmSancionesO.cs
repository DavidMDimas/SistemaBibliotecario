using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_bibliotecario
{
    public partial class frmSancionesO : Form
    {
        public frmSancionesO()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtID.Text = "";
            txtMat.Text = "";
            txtISBN.Text = "";
            txtNumR.Text = "";
            txtIdPres.Text = "";
            txtDias.Text = "";
            txtMonto.Text = "";
            txtEstatus.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                dataSancion.DataSource = NSancionO.MostrarSO();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrestamos frm = new frmPrestamos();

            
            frm.Show();

            this.Hide();
        }

        private void btnEliminarS_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtID.Text == string.Empty)
                {
                    errorIco.SetError(txtID, "Seleccione el id de la sanción");
                }
                else
                {
                    errorIco.Clear();
                    DialogResult res = MessageBox.Show("Realmente desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        NSancionO.Eliminar(Convert.ToInt32(this.txtID.Text));
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataSancion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["id_sancion"].Value);
                txtMat.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["matricula"].Value);
                txtISBN.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["isbn"].Value);
                txtIdPres.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["id_prestamo"].Value);
                txtNumR.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["num_referencia"].Value);
                txtFecha.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["fecha_prestamo"].Value);
                txtDias.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["dias"].Value);
                txtMonto.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["total_pago"].Value);
                txtEstatus.Text = Convert.ToString(this.dataSancion.CurrentRow.Cells["estatus"].Value);
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
                this.dataSancion.DataSource = NSancionO.MostrarSancionesGeneralM(txtMat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtID.Text == string.Empty)
                {
                    errorIco.SetError(txtID, "Seleccione el id de la sanción");
                }
                else
                {
                    errorIco.Clear();
                    DialogResult res = MessageBox.Show("Realmente desea modificar el registro?", "Modificar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        NSancionO.Modificar(Convert.ToInt32(this.txtID.Text),txtMat.Text,txtISBN.Text,Convert.ToInt32(txtIdPres.Text),txtNumR.Text,txtFecha.Value, Convert.ToInt32(txtDias.Text), Convert.ToDouble(txtMonto.Text),txtEstatus.Text);
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmSancionesO_Load(object sender, EventArgs e)
        {

        }

        private void txtIdPres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }
    }
}
