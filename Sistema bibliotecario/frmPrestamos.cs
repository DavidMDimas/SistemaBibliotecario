using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;

namespace Sistema_bibliotecario
{
    public partial class frmPrestamos : Form
    {
        DataTable dt;
        int counter = 0;
        string[] isbn = new string[3] {"","",""};

        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void LimpiarDT()
        {
            if (dataListado != null) dataListado.Rows.Clear();
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtNombreCompleto.Text = "";
            txtApellidos.Text = "";
            txtCarrera.Text = "";
            txtEmail.Text = "";
            txtIsbn.Text="";
            txtObservaciones.Text = "";
        }

        private void rechazado(bool estatus)
        {
            if (estatus == true)
            {
                gbLibros.Enabled = false;
                btnSancion.Enabled = true;
                lblEstatus.Text = "Rechazado";
                lblEstatus.ForeColor = Color.Red;
                btnPrestamo.Enabled = false;
                btnEntrega.Enabled = false;
            }
            else
            {
                gbLibros.Enabled = true;
                btnSancion.Enabled = false;
                lblEstatus.Text = "Aceptado";
                lblEstatus.ForeColor = Color.LightGreen;
                btnPrestamo.Enabled = true;
            }
        }

        private void VerificarFechaLimite()
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;            

            SqlCon.Open();
            try
            {

                //Aqui no SP XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                string SqlSelectQuery = "select SegundaRenovacion from Prestamos where Matricula="+txtMatricula.Text+ " and Prestamos.idPrestamo = (select max(Prestamos.idPrestamo) from Prestamos where Matricula=" + txtMatricula.Text + ");";
                string SqlEstatusQuery = "select Estatus from Prestamos where Matricula=" + txtMatricula.Text + " and Estatus='1' and Prestamos.idPrestamo = (select max(Prestamos.idPrestamo) from Prestamos where Matricula=" + txtMatricula.Text + ");";

                //string SqlEstatusQuery = "select SegundaRenovacion,Estatus from Prestamos where Matricula=" + txtMatricula.Text + " and Estatus='1';";
                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlCommand cmdEstatus = new SqlCommand(SqlEstatusQuery, SqlCon);

                cmdEstatus.Parameters.AddWithValue("Matricula", txtMatricula.Text);

                int count = Convert.ToInt32(cmdEstatus.ExecuteScalar());

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtFechaLimite.Value = Convert.ToDateTime(dr["SegundaRenovacion"]);
                    Sancionar(txtFechaLimite.Value, count);
                    //label8.Text = Convert.ToString(count);
                }
                else
                {
                    //MessageBox.Show("No se encontro ningun libro pedido hasta el momento", "No hay libros encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rechazado(false);
                    btnSancion.Enabled = false;
                }

                dr.Close();
                SqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Sancionar(DateTime fechaLimite,int estatus)
        {
            try
            {
                DateTime fechaActual = DateTime.Now.Date;
                
                if (fechaLimite < fechaActual && estatus > 0)
                {
                    //MessageBox.Show("Sancion Requerida excediste la fecha limite para entregar los libros","Sancion necesaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NPrestamo.SancionarPrestamos(Convert.ToString(txtMatricula.Text));
                    rechazado(true);
                }
                else if (fechaLimite >= fechaActual && estatus > 0)
                {
                    //MessageBox.Show("Aun no tienes sanciones pero tienes libros que no has entregado", "Libros pendientes de entrega", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frmVerPrestamos frm = new frmVerPrestamos();
                    frm.txtMatricula.Text = txtMatricula.Text;

                    frm.Show();
                    //this.Hide();

                    rechazado(true);
                    btnEntrega.Enabled = true;
                    btnSancion.Enabled = false;
                }
                else{
                    //MessageBox.Show("No adeudas ningun sancion", "Sin sancion requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFechaLimite.Value = DateTime.Now;
                    rechazado(false);
                    btnEntrega.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void EstatusUsuario()
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();

            try
            {
                //AQUI NO SP XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                string sqlQuery = "select Matricula, Estatus FROM Prestamos WHERE Matricula =" + txtMatricula.Text + "AND Estatus = '1'";

                SqlCommand command = new SqlCommand(sqlQuery, SqlCon);
                command.Parameters.AddWithValue("Matricula", txtMatricula.Text);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    lblEstatus.Text = "Aceptado";
                    lblEstatus.ForeColor = Color.LightGreen;
                    btnPrestamo.Enabled = true;
                    rechazado(false);
                }
                else
                {
                    lblEstatus.Text = "Rechazado";
                    lblEstatus.ForeColor = Color.Red;
                    btnPrestamo.Enabled = false;
                    rechazado(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Verificar()
        {
            lblISBN1.Text = Convert.ToString(isbn[0]);
            lblISBN2.Text = Convert.ToString(isbn[1]);
            lblISBN3.Text = Convert.ToString(isbn[2]);
        }

        private void Eliminar()
        {
            counter = 0;
            Limpiar();
            for (int i = 0; i < isbn.Length; i++)
            {
                isbn[i] = "";
            }

            lblISBN1.Text = "";
            lblISBN2.Text = "";
            lblISBN3.Text = "";
        }

        private void AgregarLibro()
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();
            try
            {
                //Procedimiento creado YA SPBuscarAlumnoPrestamo
                //**********************************************ANALIZAR *********************************
                string SqlSelectQuery = "select IdUsuario,matricula,nombre,apellidos, carrera,  email from Usuarios WHERE matricula = " + (txtMatricula.Text);

                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtId.Text = (dr["IdUsuario"].ToString());
                    txtMatricula.Text = (dr["matricula"].ToString());
                    txtNombreCompleto.Text = (dr["nombre"].ToString());
                    txtApellidos.Text = (dr["apellidos"].ToString());
                    txtCarrera.Text = (dr["carrera"].ToString());
                    txtEmail.Text = (dr["email"].ToString());
                }

                dr.Close();
                SqlCon.Close();

                //EstatusUsuario();

                VerificarFechaLimite();
                //cuentaLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarIsbn_Click(object sender, EventArgs e)
        {
            //counterBooks = this.dataListado.Rows.Count.ToString();
            //cuentaLibros = Convert.ToInt32(counterBooks) - 1;
            try
            {
                bool existe = dataListado.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["ISBN"].Value) == txtIsbn.Text);
                SqlConnection SqlCon = new SqlConnection();
                SqlCon.ConnectionString = Conexion.ConexionDB;
                SqlCon.Open();

                if (txtIsbn.Text == "")
                {
                    MessageBox.Show("Ingresa un valor valido");
                }
                else if (counter <= 2 && !existe)
                {
                    //AgregarLibro();
                    
                    //****************************************CREAR PROCEDIMIENTO ALMACENADO
                    //string SqlSelectQuery = "select Libros.isbn as 'ISBN',Libros.titulo as 'TITULO',Libros.editorial as 'EDITORIAL',Libros.autores as 'AUTOR',Usuarios.nombre as 'ALUMNO' from Libros,Prestamos,Usuarios where Prestamos.ISBN=Libros.isbn and Prestamos.matricula='201421448' and Usuarios.nombre='Juan';";
                    string SqlSelectQuery = "select isbn as 'ISBN',titulo AS 'TITULO', editorial AS 'EDITORIAL', autores AS 'AUTORES' from Libros where isbn='" + txtIsbn.Text + "';";

                    SqlCommand sqlCmd = new SqlCommand(SqlSelectQuery, SqlCon);

                    SqlDataReader dr = sqlCmd.ExecuteReader();

                    if (dr.Read())
                    {

                        dataListado.Rows.Add((dr["ISBN"].ToString()), (dr["TITULO"].ToString()), (dr["EDITORIAL"].ToString()), (dr["AUTORES"].ToString()));
                        isbn[counter] = Convert.ToString(this.dataListado[0, counter].Value);
                        counter++;
                        txtIsbn.Text = "";
                        Verificar();
                        /*foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {

                            fila.Cells["ISBN"].Value = (dr["ISBN"].ToString());
                            fila.Cells["TITULO"].Value = (dr["TITULO"].ToString());
                            fila.Cells["EDITORIAL"].Value = (dr["EDITORIAL"].ToString());
                            fila.Cells["AUTORES"].Value = (dr["AUTORES"].ToString());
                        }*/
                    }
                    else
                    {

                    }

                    dr.Close();
                    SqlCon.Close();


                    
                }
                else if (existe)
                {
                    MessageBox.Show("El libro ya esta ingresado");
                }
                else if (counter > 2)
                {
                    MessageBox.Show("Limite de libros alcanzado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            /*string[]  isbn= { "111", "222", "333" };
            isbn[1] = "222";
            isbn[2] = "333";*/
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //dataListado.DataSource = NSancionO.MostrarSO();
            //dataListado.DataSource = NLibros.Mostrar();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty || isbn[0] == "")
                {
                    errorIcono.SetError(txtMatricula, "Ingrese matricula");
                    MessageBox.Show("Ingrese por lo menos un ISBN valido",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Guardar prestamo", "Autorizar prestamos", MessageBoxButtons.YesNo);
                    errorIcono.Clear();
                    if (resul == DialogResult.Yes)
                    {
                        NPrestamo.Insertar(txtMatricula.Text, txtcbTipoprestamo.Text, isbn[0], isbn[1], isbn[2], txtdtFechaPrestamo.Value,
                            txtdtPrimerRenovacion.Value, txtdtSegundaRenovacion.Value, txtObservaciones.Text, "1");
                        gbLibros.Enabled = false;
                        btnPrestamo.Enabled = false;                        
                        Limpiar();
                        LimpiarDT();
                        Eliminar();
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
            //Eliminar();
            try
            {
                DialogResult resul = MessageBox.Show("Desea eliminar este libro", "Eliminar libro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    //counter--;
                    if (dataListado.CurrentRow.Index == 0)
                    {
                        isbn[0] = isbn[1];
                        isbn[1] = isbn[2];
                        isbn[2] = "";
                        counter--;

                        dataListado.Rows.Remove(dataListado.CurrentRow);
                    }
                    else if (dataListado.CurrentRow.Index == 1)
                    {
                        isbn[0] = isbn[0];
                        isbn[1] = isbn[2];
                        isbn[2] = isbn[2];
                        counter = counter - 1;
                        dataListado.Rows.Remove(dataListado.CurrentRow);
                    }
                    else if (dataListado.CurrentRow.Index == 2)
                    {
                        isbn[0] = isbn[0];
                        isbn[1] = isbn[1];
                        isbn[2] = "";
                        counter = counter - 1;
                        dataListado.Rows.Remove(dataListado.CurrentRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resul = MessageBox.Show("Esta seguro que desea esta seleccion de libros?", "Confirmar libros", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    gbLibros.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnSancion_Click(object sender, EventArgs e)
        {
            frmSancionO frm = new frmSancionO();
            frm.txtMatriculaSancion.Text = txtMatricula.Text;

            frm.lblAdeudo.Text = lblEstatus.Text;
            frm.lblAdeudo.ForeColor = lblEstatus.ForeColor;

            frm.txtFechaSancion.Value = txtFechaLimite.Value;

            frm.Show();
            this.Hide();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            this.txtMatricula.Select();
            gbLibros.Enabled = false;
            txtdtFechaPrestamo.Value= DateTime.Now;
            txtdtPrimerRenovacion.Value=DateTime.Today.AddDays(3);
            txtdtSegundaRenovacion.Value = DateTime.Today.AddDays(6);
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            // NPrestamo.SancionarPrestamos("2014000000");
            //label1.Text=Convert.ToString(dataListado.CurrentRow.Index);
            NSancionO.BuscarSancionMatricula(this.txtMatricula.Text);
        }

        /*
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            DateTime fechaLimite;
            string fechaVacia;

            SqlCon.Open();
            try
            {
                string SqlSelectQuery = "select SegundaRenovacion from Prestamos where Matricula='201421448';";

                SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //

                    if (DBNull.Value.Equals(dr["SegundaRenovacion"])) { 
                        label8.Text = Convert.ToString(dr["SegundaRenovacion"]);
                    }
                    else
                    {
                        txtFechaLimite.Value = Convert.ToDateTime(dr["SegundaRenovacion"]);
                    }
                }

                

                dr.Close();
                SqlCon.Close();

                fechaLimite = txtFechaLimite.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }*/

        private void txtdtFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaLimite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gbLibros_Enter(object sender, EventArgs e)
        {

        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void btnEntrega_Click_1(object sender, EventArgs e)
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
                        Limpiar();
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

        private void btnAbrirSanciones_Click(object sender, EventArgs e)
        {
            frmSancionesO frm = new frmSancionesO();
            frm.Show();
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            Eliminar();
            LimpiarDT();
        }
    }
}
