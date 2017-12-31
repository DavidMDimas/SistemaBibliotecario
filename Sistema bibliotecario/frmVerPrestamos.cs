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
    public partial class frmVerPrestamos : Form
    {
        public frmVerPrestamos()
        {
            InitializeComponent();
        }

        private void CargarTodo(string matricula)
        {
            try { 
                this.dataPrestamos.DataSource = NPrestamo.MostrarLibrosPrestamoMat(matricula);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmVerPrestamos_Load(object sender, EventArgs e)
        {
            CargarTodo(txtMatricula.Text);
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty)
                {
                    errorIcono.SetError(txtMatricula, "Ingrese matricula");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("¿Realizar entrega?", "Realizar Entrega", MessageBoxButtons.YesNo);
                    errorIcono.Clear();
                    if (resul == DialogResult.Yes)
                    {
                        NPrestamo.EntregaLibros(txtMatricula.Text);
                        btnEntrega.Enabled = false;                        
                    }
                    else
                    {
                        btnEntrega.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //frmPrestamos frm = new frmPrestamos();
            //frm.Show();
            Hide();
        }
    }
}
