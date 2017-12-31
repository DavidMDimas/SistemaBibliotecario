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

namespace Sistema_bibliotecario
{
    public partial class frmSancion : Form
    {
        public frmSancion()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtIdSancion.Text = "";
            txtMatriculaSancion.Text = "";
            txtNombreAlSancion.Text = "";
            txtApellidoAlSancion.Text = "";
            txtCarreraSancion.Text = "";
            txtTurnoSancion.Text = "";
            txtGrupoSancion.Text = "";
            txtCorreoSancion.Text = "";
            txtFechaSancion.Text = "";
            txtMultaDiaSancion.Text = "";
            txtDiasRetrasoSancion.Text = "";
            txtPagoSancion.Text = "";
            txtBusquedaMatSancion.Text = "";
        }

        //CRUD Create, Read, Update, Delete
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //NSancion.Insertar("201421448", "GreenPanther", "JM", "Computacion", "Vesper", "1702", "toto.com.mx", this.txtFechaSancion.Value, Convert.ToDouble(50.76), Convert.ToInt32(8), Convert.ToDouble(500));
            try
            {
                if (this.txtMatriculaSancion.Text==string.Empty || this.txtPagoSancion.Text==string.Empty)
                {
                    errorIcon.SetError(txtMatriculaSancion, "Ingrese la matricula");
                    errorIcon.SetError(txtPagoSancion, "Calcula el monto antes de poder continuar");
                }
                else
                {
                    errorIcon.Clear();
                    DialogResult res = MessageBox.Show("Desea guardar el registro?", "Guardar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes) { 
                        NSancion.Insertar(this.txtMatriculaSancion.Text, this.txtNombreAlSancion.Text, this.txtApellidoAlSancion.Text,this.txtCarreraSancion.Text, this.txtTurnoSancion.Text, 
                            this.txtGrupoSancion.Text,this.txtCorreoSancion.Text,this.txtFechaSancion.Value, Convert.ToDouble(txtMultaDiaSancion.Text),
                            Convert.ToInt32(txtDiasRetrasoSancion.Text), Convert.ToDouble(txtPagoSancion.Text));
                        Limpiar();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //NSancion.Modificar(Convert.ToInt32(6), "201421448", "GreenPanther", "JM", "Computacion", "Vesper", "1702", "toto.com.mx", this.txtFechaSancion.Value, Convert.ToDouble(50.76), Convert.ToInt32(6), Convert.ToDouble(500));
            try
            {
                if (this.txtMatriculaSancion.Text == string.Empty)
                {
                    errorIcon.SetError(txtMatriculaSancion, "Ingrese la matricula");
                }
                else
                {
                    errorIcon.Clear();
                    DialogResult res = MessageBox.Show("Desea modificar el registro?", "Modificar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        NSancion.Modificar(Convert.ToInt32(this.txtIdSancion.Text),this.txtMatriculaSancion.Text, this.txtNombreAlSancion.Text, this.txtApellidoAlSancion.Text, this.txtCarreraSancion.Text, this.txtTurnoSancion.Text,
                            this.txtGrupoSancion.Text, this.txtCorreoSancion.Text, this.txtFechaSancion.Value, Convert.ToDouble(txtMultaDiaSancion.Text),
                            Convert.ToInt32(txtDiasRetrasoSancion.Text), Convert.ToDouble(txtPagoSancion.Text));
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NSancion.Eliminar(Convert.ToInt32(2));
            try
            {
                if (this.txtIdSancion.Text == string.Empty)
                {
                    errorIcon.SetError(txtIdSancion, "Ingrese el id de la sanción");
                }
                else
                {
                    errorIcon.Clear();
                    DialogResult res = MessageBox.Show("Realmente desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        NSancion.Eliminar(Convert.ToInt32(this.txtIdSancion.Text));
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dataSanciones.DataSource = NSancion.BuscarSancionesPorMatricula("201421448");
            try
            {
                this.dataSanciones.DataSource = NSancion.BuscarSancionesPorMatricula(this.txtBusquedaMatSancion.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
              dataSanciones.DataSource = NSancion.Mostrar();
        }

        private void dataSanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["id_sancion"].Value);
            txtMatriculaSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["matricula"].Value);
            txtNombreAlSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["nombre"].Value);
            txtApellidoAlSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["apellidos"].Value);
            txtCarreraSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["carrera"].Value);
            txtTurnoSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["turno"].Value);
            txtGrupoSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["grupo"].Value);
            txtCorreoSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["email"].Value);
            txtFechaSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["fecha_prestamo"].Value);
            txtMultaDiaSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["pagofinal"].Value);
            txtDiasRetrasoSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["dias_retraso"].Value);
            txtPagoSancion.Text = Convert.ToString(this.dataSanciones.CurrentRow.Cells["monto_final"].Value);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double multaPorDia = Convert.ToDouble(txtMultaDiaSancion.Text);
            int dias = Convert.ToInt32(txtDiasRetrasoSancion.Text);
            double pagoF = Convert.ToDouble(txtPagoSancion.Text);
        }

        private void frmSancion_Load(object sender, EventArgs e)
        {

        }
    }
}
