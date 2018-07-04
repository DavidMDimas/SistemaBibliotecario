using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema_bibliotecario
{
    

    public partial class MenunPrincipal : Form
    {
        public MenunPrincipal()
        {
            InitializeComponent();
        }

        private frmLibros form = null;

        public delegate void FormPrestamosVer(frmPrestamos frmP);

        private frmLibros FormInstance
        {
            get
            {
                if (form == null)
                {
                    form = new frmLibros();
                    form.MdiParent = this;

                    
                    form.Disposed += new EventHandler(form_Disposed);
                    /*form.FormClosed += new FormClosedEventHandler(form_FormClosed);
                    form.Load += new EventHandler(form_Load);*/
                    
                }
                
                return form;
            }
        }

        /*
        void form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario abierto"); 
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Formulario cerrado");
        }*/

        void form_Disposed(object sender, EventArgs e)
        {
            form = null;
        }

        public void frmLibrosLoad(frmPrestamos frmP)
        {
            
            
        }

        public void frmPrestamosLoad()
        {


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
            /*
            frmLibros FLibro = new frmLibros();
            FLibro.MdiParent = this;
            FLibro.Show();*/

            frmLibros frm = this.FormInstance;

            // se varifica si el formulario no esta minimizado, en caso de estarlo
            // se lo cambia a un estado normal
            if (frm.WindowState == FormWindowState.Minimized)
                frm.WindowState = FormWindowState.Normal;

            frm.Show();
            
        }

        private void nuevoEditorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditorial FEditorial = new frmEditorial();
            //FEditorial.MdiParent = this;
            FEditorial.ShowDialog();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            acercade FAcerca = new acercade();
            FAcerca.MdiParent = this;
            FAcerca.Show();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario FUsuario = new frmUsuario();
            FUsuario.MdiParent = this;
            FUsuario.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos fprestamo = new frmPrestamos();
            //CargarFormsHilos prestamos = new CargarFormsHilos(fprestamo);
            //CargarFormsHilos prestamos = new CargarFormsHilos();
            fprestamo.MdiParent = this;
            fprestamo.Show();
            //prestamos.frmPrestamosLoad();
            
            /*
            Thread th = new Thread(new ThreadStart(prestamos.FrmPrestamosLoad));

            th.Start();
            th.Join();*/
        }

        private void MenunPrincipal_Load(object sender, EventArgs e)
        {
            /*
            Carga carga = new Carga();
            Thread th = new Thread(new ThreadStart(carga.CargaForm));

            th.Start();
            th.Join();*/
        }

        private void controlDeSancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSancionesO frmsanciones = new frmSancionesO();
            frmsanciones.MdiParent = this;

            frmsanciones.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarLibro FBuscarLibro = new frmBuscarLibro();
            FBuscarLibro.MdiParent = this;
            FBuscarLibro.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes fReportes = new frmReportes();
            fReportes.MdiParent = this;
            fReportes.Show();
        }

        private void sancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSancionO frmsancion = new frmSancionO();
            frmsancion.MdiParent = this;
            frmsancion.txtMatriculaSancion.Text = "";

            frmsancion.Show();
        }
    }

    public class CargarFormsHilos: MenunPrincipal
    {
        /*
        private frmPrestamos _frmP;

        public CargarFormsHilos(frmPrestamos frmP)
        {
             _frmP = frmP;


        }*/

        public void frmLibrosLoad()
        {

        }

        public void FrmPrestamosLoad()
        {

            frmPrestamos _frmP = new frmPrestamos();
            _frmP.Show();
            //Thread.Sleep(10000);
        }

    }
}
