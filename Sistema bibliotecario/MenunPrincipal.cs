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
    public partial class MenunPrincipal : Form
    {
        public MenunPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutor FAutor = new frmAutor();
            FAutor.MdiParent = this;
            FAutor.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAcceso FLogin = new LoginAcceso();
            FLogin.Show();
            Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void nuevoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibros FLibro = new frmLibros();
            FLibro.MdiParent = this;
            FLibro.Show();
        }

        private void nuevoEditorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditorial FEditorial = new frmEditorial();
            FEditorial.MdiParent = this;
            FEditorial.Show();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            acercade FAcerca = new acercade();
            FAcerca.MdiParent = this;
            FAcerca.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarLibro FBuscarLibro = new frmBuscarLibro();
            FBuscarLibro.MdiParent = this;
            FBuscarLibro.Show();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario FUsuario = new frmUsuario();
            FUsuario.MdiParent = this;
            FUsuario.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamo fprestamo = new frmPrestamo();
            fprestamo.MdiParent = this;
            fprestamo.Show();
        }
    }
}
