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
    public partial class frmMonitordeEventos : Form
    {
        public frmMonitordeEventos()
        {
            InitializeComponent();
        }

        private void frmMonitordeEventos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == string.Empty)
                {
                    errorIcono.SetError(textBox1, "Ingresa un valor");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Deseas guardar el registro", "Guardar registro", MessageBoxButtons.YesNo);
                    if(resul == DialogResult.Yes)
                    {
                        //NSancion.Insertar(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox1.Text), dateTimePicker1.Value);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
