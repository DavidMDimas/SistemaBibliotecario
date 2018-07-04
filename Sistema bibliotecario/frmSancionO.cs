using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace Sistema_bibliotecario
{
    public partial class frmSancionO : Form
    {
        int dias;
        DataTable dt;

        public frmSancionO()
        {
            InitializeComponent();
        }

        private void cargarTodo(string matricula)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;
            SqlCon.Open();

            try
            {
                //string SqlSelectQuery = "select Usuarios.matricula as 'matricula', (Usuarios.nombre + Usuarios.apellidos) as 'Nombre CCompleto',Usuarios.carrera as 'carrera',Usuarios.email as 'email',Sancion.nombre as 'SancNombre' from Usuarios,Sancion where Usuarios.matricula=" + (txtMatriculaSancion.Text)+" and Sancion.nombre='otro'";
                string SqlSelectQuery = "select matricula, nombre as 'Nombre CC',apellidos,carrera,email from Usuarios where matricula = " + (txtMatriculaSancion.Text);
                SqlCommand sqlCmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = sqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    txtMatriculaSancion.Text = (dr["matricula"].ToString());
                    txtNombreSancion.Text = (dr["Nombre CC"].ToString());
                    txtApellidos.Text = (dr["apellidos"].ToString());
                    txtCarreraSancion.Text = (dr["carrera"].ToString());
                    txtCorreoSancion.Text = (dr["email"].ToString());
                }

                this.dataListado.DataSource = NSancionO.BuscarSancionMatricula(this.txtMatriculaSancion.Text);
                
                dr.Close();
                SqlCon.Close();
                getDataLista();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void fecha()
        {
            try
            {
                DateTime fechaExpiracion = (txtFechaSancion.Value);
                DateTime diasExp = DateTime.Now;
                double montoFinal;

                TimeSpan ts = diasExp - fechaExpiracion;
                dias = ts.Days;
                txtDiasRetrasoSancion.Text = Convert.ToString(dias);

                //Multa por dia 8.00$ MXN.
                montoFinal = dias * 8.00;

                txtPagoSancion.Text = Convert.ToString(montoFinal);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmSancionO_Load(object sender, EventArgs e)
        {
            if (txtMatriculaSancion.Text == "")
            {

            }
            else
            {
                cargarTodo(txtMatriculaSancion.Text);
                fecha();
            }
        }

        public void Limpiar(Control objContenedor)
        {
            //txtMatriculaSancion.Text = "";
            txtNombreSancion.Text = "";
            txtApellidos.Text = "";
            txtCarreraSancion.Text = "";
            txtCorreoSancion.Text = "";
            txtDiasRetrasoSancion.Text = "";
            txtPagoSancion.Text = "";
        }

        private void getDataLista()
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;
            SqlCon.Open();

            try
            {
                //****************************************************************************** CREAR PROCEDIMIENTO ALMACENADO

                //string SqlSelectQuery = "select Libros.isbn as 'ISBN',Libros.titulo as 'TITULO',Libros.editorial as 'EDITORIAL',Libros.autores as 'AUTOR',Usuarios.nombre as 'ALUMNO' from Libros,Prestamos,Usuarios where Prestamos.ISBN=Libros.isbn and Prestamos.matricula='201421448' and Usuarios.nombre='Juan';";
                /*string SqlSelectQuery = "select Prestamos.idPrestamo as 'PRESTAMOID',Libros.isbn as 'ISBN',Libros.titulo as 'TITULO',Libros.editorial as 'EDITORIAL',Libros.autores as 'AUTOR',Usuarios.nombre as 'ALUMNO',Prestamos.Estatus as 'ESTADO' from Libros,Prestamos,Usuarios where Prestamos.matricula=" + (txtMatriculaSancion.Text)+ " and Usuarios.matricula=Prestamos.matricula and Prestamos.ISBN=Libros.isbn and Prestamos.idPrestamo = (select max(Prestamos.idPrestamo) from Prestamos where Matricula = " + (txtMatriculaSancion.Text) + ")" +
                    "union all select Prestamos.idPrestamo as 'PRESTAMOID',Libros.isbn as 'ISBN',Libros.titulo as 'TITULO',Libros.editorial as 'EDITORIAL',Libros.autores as 'AUTOR',Usuarios.nombre as 'ALUMNO',Prestamos.Estatus as 'ESTADO' from Libros,Prestamos,Usuarios where Prestamos.matricula=" + (txtMatriculaSancion.Text) + " and Usuarios.matricula=Prestamos.matricula and Prestamos.ISBN2=Libros.isbn and Prestamos.idPrestamo = (select max(Prestamos.idPrestamo) from Prestamos where Matricula = " + (txtMatriculaSancion.Text) + ")" +
                    "union all select Prestamos.idPrestamo as 'PRESTAMOID',Libros.isbn as 'ISBN',Libros.titulo as 'TITULO',Libros.editorial as 'EDITORIAL',Libros.autores as 'AUTOR',Usuarios.nombre as 'ALUMNO',Prestamos.Estatus as 'ESTADO' from Libros,Prestamos,Usuarios where Prestamos.matricula=" + (txtMatriculaSancion.Text) + " and Usuarios.matricula=Prestamos.matricula and Prestamos.ISBN3=Libros.isbn and Prestamos.idPrestamo = (select max(Prestamos.idPrestamo) from Prestamos where Matricula = " + (txtMatriculaSancion.Text) + ");"; */
                string sqlQueryEstatus = "select Matricula, Estatus FROM Prestamos WHERE Matricula =" + (txtMatriculaSancion.Text) + "AND Estatus = '1'";
                //SqlCommand sqlCmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlCommand sqlCmdEstatus = new SqlCommand(sqlQueryEstatus, SqlCon);

                sqlCmdEstatus.Parameters.AddWithValue("Matricula", txtMatriculaSancion.Text);
                int counter = Convert.ToInt32(sqlCmdEstatus.ExecuteScalar());

                /*
                if (counter == 0)
                {
                    lblAdeudo.Text = "Sin adeudos";
                    lblAdeudo.ForeColor = Color.Black;
                    gbAdeudo.BackColor = Color.LightBlue;
                }
                else
                {
                    lblAdeudo.Text = "Sancion requerida";
                    lblAdeudo.ForeColor = Color.LightYellow;
                    gbAdeudo.BackColor = Color.LightSalmon;
                }*/

                //////////////

                /*SqlDataAdapter adapter = new SqlDataAdapter(SqlSelectQuery, SqlCon);
                dt = new DataTable();
                adapter.Fill(dt);
                dataListado.DataSource = dt;*/
                ////////////////

                //SqlDataReader dr = sqlCmd.ExecuteReader();

                /*if (dr.Read())
                {

                    foreach (DataGridViewRow fila in dataListado.Rows)
                    {
                        fila.Cells["idprestamo"].Value = (dr["PRESTAMOID"]);
                        fila.Cells["isbn"].Value= (dr["ISBN"]);
                        fila.Cells["titulo"].Value = (dr["TITULO"].ToString());
                        fila.Cells["editorial"].Value = (dr["EDITORIAL"].ToString());
                        fila.Cells["autor"].Value = (dr["AUTOR"].ToString());
                        fila.Cells["usuario"].Value = (dr["ALUMNO"].ToString());
                        fila.Cells["estado"].Value = (dr["ESTADO"].ToString());
                    }

                    /*for (int fila = 0; fila < dataListado.Rows.Count - 1; fila++)
                    {
                        for (int col = 0; col < dataListado.Rows[fila].Cells.Count; col++)
                        {
                            string valor = dataListado.Rows[fila].Cells[col].Value.ToString();
                            MessageBox.Show(valor);
                            //dataListado.Cells["isbn"].Value = dataListado.Rows[fila].Cells[col].Value.ToString();
                            dataListado.Cells["isbn"].Value = (dr["ISBN"]);
                        }
                    }
                    */
                //}

                SqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void rechazado(bool estatus)
        {
            if (estatus == true)
            {
                lblAdeudo.Text = "Rechazado";
                lblAdeudo.ForeColor = Color.Red;
            }
            else
            {
                lblAdeudo.Text = "Aceptado";
                lblAdeudo.ForeColor = Color.LightGreen;
            }
        }

        private void VerificarFechaLimite()
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();
            try
            {
                string SqlSelectQuery = "select SegundaRenovacion from Prestamos where Matricula=" + txtMatriculaSancion.Text + " and Prestamos.idPrestamo = (select max(Prestamos.idPrestamo) from Prestamos where Matricula=" + txtMatriculaSancion.Text + ");";
                string SqlEstatusQuery = "select Estatus from Prestamos where Matricula=" + txtMatriculaSancion.Text + " and Estatus='1' and Prestamos.idPrestamo = (select max(Prestamos.idPrestamo) from Prestamos where Matricula=" + txtMatriculaSancion.Text + ");";

                //string SqlEstatusQuery = "select SegundaRenovacion,Estatus from Prestamos where Matricula=" + txtMatricula.Text + " and Estatus='1';";
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlCommand cmdEstatus = new SqlCommand(SqlEstatusQuery, SqlCon);

                cmdEstatus.Parameters.AddWithValue("Matricula", txtMatriculaSancion.Text);

                int count = Convert.ToInt32(cmdEstatus.ExecuteScalar());

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtFechaSancion.Value = Convert.ToDateTime(dr["SegundaRenovacion"]);
                    Sancionar(txtFechaSancion.Value, count);
                    //label8.Text = Convert.ToString(count);
                }
                else
                {
                    MessageBox.Show("No se encontro ningun libro pedido hasta el momento", "No hay libros encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rechazado(false);
                }

                dr.Close();
                SqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Sancionar(DateTime fechaLimite, int estatus)
        {
            try
            {
                DateTime fechaActual = DateTime.Now.Date;

                if (fechaLimite < fechaActual && estatus > 0)
                {

                    //MessageBox.Show("Sancion Requerida excediste la fecha limite para entregar los libros","Sancion necesaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NPrestamo.SancionarPrestamos(Convert.ToString(txtMatriculaSancion.Text));

                    fecha();
                    rechazado(true);
                }
                else if (fechaLimite >= fechaActual && estatus > 0)
                {
                    //MessageBox.Show("Aun no tienes sanciones pero tienes libros que no has entregado", "Libros pendientes de entrega", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frmVerPrestamos frm = new frmVerPrestamos();
                    frm.txtMatricula.Text = txtMatriculaSancion.Text;

                    frm.Show();
                    //this.Hide();

                    rechazado(true);
                    btnEntrega.Enabled = true;
                }
                else
                {
                    //MessageBox.Show("No adeudas ningun sancion", "Sin sancion requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFechaSancion.Value = DateTime.Now;
                    rechazado(false);
                    btnEntrega.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private bool Aceptado(string adeudo)
        {
            if(adeudo=="Rechazado" || adeudo == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*NSancionO.Insertar(txtMatriculaSancion.Text, "NE", 0, txtReferencia.Text, 
                txtFechaSancion.Value, Convert.ToInt32(txtDiasRetrasoSancion.Text), Convert.ToDouble(txtPagoSancion.Text));*/
            try
            { 
                int idPrestamo = Convert.ToInt32(this.dataListado.CurrentRow.Cells["PRESTAMOID"].Value);
                string isbnLibro = Convert.ToString(this.dataListado.CurrentRow.Cells["ISBN"].Value);
                string estatus = Convert.ToString(this.dataListado.CurrentRow.Cells["ESTADO"].Value);

                if (idPrestamo == 0 || isbnLibro == null || txtPagoSancion.Text==string.Empty || estatus == string.Empty)
                {
                    MessageBox.Show("Error en los valores, Porfavor seleccione los datos de la tabla una vez" +
                    " que haya cargado la matricula y tras haber calculado el monto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult res = MessageBox.Show("¿Desea registrar la Sancion?", "Registrar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        NSancionO.Insertar(this.txtMatriculaSancion.Text, isbnLibro, idPrestamo, this.txtReferencia.Text,this.txtFechaSancion.Value, dias, Convert.ToDouble(this.txtPagoSancion.Text),estatus);
                        //Limpiar(this);
                        btnGuardar.Enabled = false;
                        btnEntrega.Enabled = true;
                    }
                    else
                    {

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                
            }            
        }

        //NSancionO.Insertar("000000", "NE", 0, "123",txtFechaSancion.Value , 3, 27,'0');
        //NSancionO.Modificar(2,"2222", "NE", 10, "456", txtFechaSancion.Value, 10, 627);
        //NSancionO.Eliminar(3);

        private void txtFechaSancion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaExpiracion = (txtFechaSancion.Value);
                DateTime diasExp = DateTime.Now;

                TimeSpan ts = diasExp - fechaExpiracion;
                dias = ts.Days;
                txtDiasRetrasoSancion.Text = Convert.ToString(dias);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCalcularMonto_Click(object sender, EventArgs e)
        {
            //double montoFinal = Convert.ToDouble(txtPagoSancion.Text);

            //Multa por dia 3.00$ MXN.
            double montoFinal;
            montoFinal = dias * 3.00;

            txtPagoSancion.Text = Convert.ToString(montoFinal);
        }
        
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtReferencia.Text == "12345678TESI" && Aceptado(lblAdeudo.Text)==false)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("Verificar que la referencia introducida sea correcta, o el alumno no adeuda ningun libro",
                    "Referencia invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAbrirSanciones_Click(object sender, EventArgs e)
        {
            frmSancionesO frm = new frmSancionesO();
            frm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiar(dataListado);
            //NSancionO.Eliminar(4);
            //NSancionO.Insertar("000000", "NE", 0, "123", txtFechaSancion.Value, 3, 27, "0");
            this.dataListado.DataSource = NSancionO.BuscarSancionMatricula(this.txtMatriculaSancion.Text);

        }

        private void btnVolverPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamos frm = new frmPrestamos();
            frm.MdiParent = this.MdiParent;
            frm.Show();

            this.Hide();
        }

        private void txtMatriculaSancion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatriculaSancion.Text == string.Empty)
                {
                    errorIcono.SetError(txtMatriculaSancion, "Ingrese matricula");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("¿Realizar pago?", "PAGO", MessageBoxButtons.YesNo);
                    errorIcono.Clear();
                    if (resul == DialogResult.Yes)
                    {
                        NPrestamo.EntregaLibros(txtMatriculaSancion.Text);
                        btnEntrega.Enabled = false;
                        frmPrestamos frm = new frmPrestamos();

                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        btnEntrega.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            //datagrid.gridview=NSancion.MostrarPorMatricula(textbox.text);
            //dataListado.Rows[0].Cells[0].Value = "Hola";
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;
            SqlCon.Open();

            try
            {
                //string SqlSelectQuery = "select Usuarios.matricula as 'matricula', (Usuarios.nombre + Usuarios.apellidos) as 'Nombre CCompleto',Usuarios.carrera as 'carrera',Usuarios.email as 'email',Sancion.nombre as 'SancNombre' from Usuarios,Sancion where Usuarios.matricula=" + (txtMatriculaSancion.Text)+" and Sancion.nombre='otro'";
                string SqlSelectQuery = "select matricula, nombre as 'Nombre CC',apellidos,carrera,email from Usuarios where matricula = " + (txtMatriculaSancion.Text);
                SqlCommand sqlCmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = sqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    txtMatriculaSancion.Text = (dr["matricula"].ToString());
                    txtNombreSancion.Text = (dr["Nombre CC"].ToString());
                    txtApellidos.Text = (dr["apellidos"].ToString());
                    txtCarreraSancion.Text = (dr["carrera"].ToString());
                    txtCorreoSancion.Text = (dr["email"].ToString());
                }

                this.dataListado.DataSource = NSancionO.BuscarSancionMatricula(this.txtMatriculaSancion.Text);

                dr.Close();
                SqlCon.Close();
                //getDataLista();
                VerificarFechaLimite();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
