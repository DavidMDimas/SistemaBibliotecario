using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using BarcodeLib;
using System.Drawing.Imaging;
using System.Threading;

namespace Sistema_bibliotecario
{
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarLibro FBuscarLibro = new frmBuscarLibro();
            FBuscarLibro.Show();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtISBN.Text == string.Empty || this.txtTitulo.Text == string.Empty || this.txtcbEditorial.Text == string.Empty
                    || txtNPaginas.Text == string.Empty)
                {

                    errorIcono.SetError(txtISBN, "Ingrese un dato");
                    errorIcono.SetError(txtTitulo, "Ingrese un dato");
                    errorIcono.SetError(txtcbEditorial, "Ingrese un dato");
                    errorIcono.SetError(txtNPaginas, "Ingrese un dato");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.imgUpload.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();

                    int txtPaginas = Convert.ToInt32(txtNPaginas.Text);
                    NLibros.Insertar(this.txtISBN.Text, this.txtTitulo.Text, this.txtcbLengua.Text, this.txtcbEditorial.Text, this.txtcbPublicacion.Text, this.txtcbGenero.Text,this.txtDisponibilidad.Text, this.txtComentarios.Text, this.txtcbAutor.Text, this.txtcbEdicion.Text, this.txtdpFechaEdicion.Value, txtPaginas, this.txtcbMateria.Text, this.txtcbSubgenero.Text, this.txtUbicacion.Text, this.txtTag.Text,this.txtCodigoBarras.Text + "TESI", imagen);

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
            try
            {
                if (this.txtISBN.Text == string.Empty || this.txtTitulo.Text == string.Empty || this.txtcbEditorial.Text == string.Empty)
                {
                    errorIcono.SetError(txtISBN, "Ingrese un dato");
                    errorIcono.SetError(txtTitulo, "Ingrese un dato");
                    errorIcono.SetError(txtcbEditorial, "Ingrese un dato");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Realmente desea modificar este registro", "Modificar registro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.imgUpload.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();

                        int txtPaginas = Convert.ToInt32(txtNPaginas.Text);
                        NLibros.Editar(this.txtISBN.Text, this.txtTitulo.Text, this.txtcbLengua.Text, this.txtcbEditorial.Text, this.txtcbPublicacion.Text, this.txtcbGenero.Text,this.txtDisponibilidad.Text, this.txtComentarios.Text, this.txtcbAutor.Text, this.txtcbEdicion.Text, this.txtdpFechaEdicion.Value, txtPaginas, this.txtcbMateria.Text, this.txtcbSubgenero.Text, this.txtUbicacion.Text, this.txtTag.Text,this.txtCodigoBarras.Text + "TESI", imagen);
                        MessageBox.Show("Registro modificado correctamente");
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
            try
            {
                DialogResult resul = MessageBox.Show("Desea eliminar este registro", "Eliminar registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    NLibros.Eliminar(txtISBN.Text);
                    MessageBox.Show("Registro eliminado");
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnUpImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    imgUpload.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void txtDisponibilidadKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                this.txtISBN.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["isbn"].Value);
                this.txtTitulo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["titulo"].Value);
                this.txtcbLengua.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["lenguaje"].Value);
                this.txtcbEditorial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["editorial"].Value);
                this.txtcbPublicacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["publicacion"].Value);
                this.txtcbGenero.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["genero"].Value);
                this.txtDisponibilidad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["disponibilidad"].Value);
                this.txtComentarios.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["comentarios"].Value);
                this.txtcbAutor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["autores"].Value);
                this.txtcbEdicion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["edicion"].Value);
                this.txtdpFechaEdicion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["fechaedicion"].Value);
                this.txtNPaginas.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["npaginas"].Value);
                this.txtcbMateria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["materia"].Value);
                this.txtcbSubgenero.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["subgenero"].Value);
                this.txtUbicacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["ubicacion"].Value);
                this.txtTag.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tag"].Value);
                this.txtCodigoBarras.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["codigobarras"].Value);


                //checa esta parte para visualizar una imagen
                byte[] imagenBuffer = (byte[])this.dataListado.CurrentRow.Cells["imagen"].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

                this.imgUpload.Image = Image.FromStream(ms);
                this.imgUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            try
            {
                Carga carga = new Carga();
                Thread th = new Thread(new ThreadStart(carga.CargaForm));

                th.Start();
                th.Join();

                txtcbEditorial.DataSource = NEditorial.Mostrar();
                txtcbEditorial.ValueMember = "IdEditorial";
                txtcbEditorial.DisplayMember = "Editorial";

                txtcbAutor.DataSource = NAutor.MostrarNombreCompleto();
                // txtcbAutor.ValueMember = "idAutor";
                txtcbAutor.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataListado.DataSource = NLibros.BuscarISBN(this.txtISBN.Text);
                txtCodigoBarras.Text = txtISBN.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            this.txtISBN.Text = "";
            this.txtTitulo.Text = "";
            this.txtcbLengua.Text = "";
            this.txtcbEditorial.Text = "";
            this.txtcbPublicacion.Text = "";
            this.txtcbGenero.Text = "";
            this.txtDisponibilidad.Text = "";
            this.txtComentarios.Text = "";
            this.txtcbAutor.Text = "";
            this.txtcbEdicion.Text = "";
            this.txtdpFechaEdicion.Text = "";
            this.txtNPaginas.Text = "";
            this.txtcbMateria.Text = "";
            this.txtcbSubgenero.Text = "";
            this.txtUbicacion.Text = "";
            this.txtTag.Text = "";
            this.txtCodigoBarras.Text = "";

            this.imgUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imgUpload.Image = global::Sistema_bibliotecario.Properties.Resources.bookPrincipal;
        }

        private void txtdpFechaEdicion_ValueChanged(object sender, EventArgs e)
        {
            // txtdpFechaEdicion.CustomFormat = "MMMM yyyy";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panelResultado.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigoBarras.Text + "TESI", Color.Black, Color.White, 200, 100);
            btnGuardarCodeBar.Enabled = true;
        }

        private void btnGuardarCodeBar_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panelResultado.BackgroundImage.Clone();
            SaveFileDialog cajaDeDialogo = new SaveFileDialog();
            cajaDeDialogo.AddExtension = true;
            cajaDeDialogo.Filter = "Image PNG (*.png)|*.png";
            cajaDeDialogo.ShowDialog();
            if (!string.IsNullOrEmpty(cajaDeDialogo.FileName))
            {
                imgFinal.Save(cajaDeDialogo.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void imgUpload_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panelResultado.BackgroundImage.Clone();
            imgUpload.Image = imgFinal;
        }

        private void txtNPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataListado.DataSource = NLibros.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged_1(object sender, EventArgs e)
        {
            this.dataListado.DataSource = NLibros.ExisteISBN(txtISBN.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}