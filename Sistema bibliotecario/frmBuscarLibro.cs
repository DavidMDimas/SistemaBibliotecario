using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Sistema_bibliotecario
{ 

    public partial class frmBuscarLibro : Form
    {
        int id,npaginas;
        string isbnLibro, titulo, lenguaje, editorial, publicacion, genero, disponibilidad, comentarios, autores, edicion, materia,subgenero,ubicacion,tag,codigobarras;
        DateTime fecha;
        //byte[] image;

        private DataTable dtLibros;

        public frmBuscarLibro()
        {
            InitializeComponent();
        }

        public void Busqueda()
        {
            Thread th1 = new Thread(new ThreadStart(Busqueda));
            th1.Start();
            th1.Join();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select IdLibro,isbn from Libros where isbn="+txtBusqueda.Text;
            this.dataBusqueda.DataSource = NBusquedas.BusquedasISBN(this.txtBusqueda.Text, dtLibros);
            /*label3.Text = String.Join(Environment.NewLine, dtLibros);
            label4.Text = String.Join(Environment.NewLine, dtLibros);*/

            
            //List<DLibro> libros = new List<DLibro>();
        }

        private void CrearTabla()
        {
            this.dtLibros = new DataTable("Libros");
            this.dtLibros.Columns.Add("IdLibro", System.Type.GetType("System.Int32"));
            this.dtLibros.Columns.Add("isbn", System.Type.GetType("System.String"));

            this.dataBusqueda.DataSource = this.dtLibros;
        }

        private void dataBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataBusqueda.Rows.Count == 0)
                {
                    errorIcon.SetError(txtBusqueda, "Ingrese un valor para busqueda");
                    txtBusqueda.Select();
                }
                else
                {
                    DialogResult res = MessageBox.Show("¿Visualizar Libro?", "Confirmar busqueda", MessageBoxButtons.YesNo);
                    errorIcon.Clear();

                    if (res == DialogResult.Yes)
                    {
                        Inicializar();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rbAutor_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
            txtBusqueda.Text = "";
        }

        private void rbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
            txtBusqueda.Text = "";
        }

        private void rbISBN_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
            txtBusqueda.Text = "";
        }

        private void frmBuscarLibro_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Select();
                this.CrearTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbISBN.Checked == true)
            {
                validaciones.solonumeros(e);
            }
        }        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbISBN.Checked == true)
                {
                    this.dataBusqueda.DataSource = NBusquedas.BusquedasISBN(this.txtBusqueda.Text, dtLibros);
                }
                else if (rbTitulo.Checked == true)
                {
                    this.dataBusqueda.DataSource = NBusquedas.BusquedasTitulo(this.txtBusqueda.Text);
                }
                else if (rbAutor.Checked == true)
                {
                    this.dataBusqueda.DataSource = NBusquedas.BusquedasAutor(this.txtBusqueda.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Inicializar()
        {

            //que buena forma de evadir un list<string> xD 

            
            id = Convert.ToInt32(this.dataBusqueda.CurrentRow.Cells["IdLibro"].Value);
            isbnLibro = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["isbn"].Value);
            titulo = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["titulo"].Value);
            lenguaje = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["lenguaje"].Value);
            editorial = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["editorial"].Value);
            publicacion = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["publicacion"].Value);
            genero = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["genero"].Value);
            disponibilidad = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["disponibilidad"].Value);
            comentarios = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["comentarios"].Value);
            autores = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["autores"].Value);
            edicion = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["edicion"].Value);
            fecha = Convert.ToDateTime(this.dataBusqueda.CurrentRow.Cells["fechaedicion"].Value);
            npaginas = Convert.ToInt32(this.dataBusqueda.CurrentRow.Cells["npaginas"].Value);
            materia = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["materia"].Value);
            subgenero = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["subgenero"].Value);
            ubicacion = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["ubicacion"].Value);
            tag = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["tag"].Value);
            codigobarras = Convert.ToString(this.dataBusqueda.CurrentRow.Cells["codigobarras"].Value);
            //image= (byte[])this.dataBusqueda.CurrentRow.Cells["imagen"].Value;

            //Image imagen = (this.dataBusqueda.CurrentRow.Cells["imagen"].Value);

            frmLibros frmL = new frmLibros();
            frmL.txtISBN.Text = isbnLibro;
            frmL.txtTitulo.Text = titulo;
            frmL.txtcbLengua.Text = lenguaje;
            frmL.txtcbEditorial.Text = editorial;
            frmL.txtcbGenero.Text = genero;
            frmL.txtDisponibilidad.Text = disponibilidad;
            frmL.txtComentarios.Text = comentarios;
            frmL.txtcbAutor.Text = autores;
            frmL.txtcbEdicion.Text = edicion;
            frmL.txtdpFechaEdicion.Value = fecha;
            frmL.txtNPaginas.Text = Convert.ToString(npaginas);
            frmL.txtcbMateria.Text = materia;
            frmL.txtcbSubgenero.Text = subgenero;
            frmL.txtUbicacion.Text = ubicacion;
            frmL.txtTag.Text = tag;
            frmL.txtCodigoBarras.Text = codigobarras;

            byte[] imagenBuffer = (byte[])this.dataBusqueda.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            frmL.imgUpload.Image = Image.FromStream(ms);
            frmL.imgUpload.SizeMode = PictureBoxSizeMode.StretchImage;

            //frmL.MdiParent=this.MdiParent;

            frmL.ShowDialog(this);
        }
    }
}
