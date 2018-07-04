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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Sistema_bibliotecario
{
    public partial class frmUsuario : Form
    {

        char[] caracteresTrim = {' '};

        public frmUsuario()
        {
            InitializeComponent();
        }
        //Alumnos/Egresados 9 digitos
        //administrativos/Profesores 4 digitos

        //regex regular expressions

        public static bool CorreoValido(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = Conexion.ConexionDB;

            SqlCon.Open();

            try
            {
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtMatricula.Text == string.Empty)
                {
                    errorIcono.SetError(txtMatricula, "Ingrese la matricula");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre");
                    errorIcono.SetError(txtApellido, "Ingrese apellido");
                }
                else
                {

                    /*
                        SqlCommand cmd = new SqlCommand("SPInsertarUsuario", SqlCon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = Convert.ToInt32(txtIdUser.Text);
                        cmd.Parameters.Add("@matricula", SqlDbType.VarChar).Value = txtMatricula.Text;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                        cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = txtApellido.Text;
                        cmd.Parameters.Add("@carrera", SqlDbType.VarChar).Value = txtcbCarrera.Text;
                        cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = txtcbSexo.Text;
                        cmd.Parameters.Add("@tipousuario", SqlDbType.VarChar).Value = txtcbTipoUsuario.Text;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;

                        cmd.ExecuteNonQuery();
                        */

                    string correo = this.txtEmail.Text.Trim(caracteresTrim);

                    if (txtMatricula.Text == txtRepetirMat.Text && txtMatricula.TextLength==9 && (txtcbTipoUsuario.Text=="Alumno" || txtcbTipoUsuario.Text == "Egresado") && CorreoValido(correo) ==true)
                    {
                        errorIcono.Clear();
                        NUsuario.Insertar(this.txtMatricula.Text, this.txtNombre.Text, this.txtApellido.Text, this.txtcbCarrera.Text,this.txtcbSexo.Text, this.txtcbTipoUsuario.Text, correo, this.dtFechaIng.Value);
                        Limpiar();
                        MessageBox.Show("Registro guardado");
                    }
                    else if (txtMatricula.Text == txtRepetirMat.Text && txtMatricula.TextLength == 4 && (txtcbTipoUsuario.Text == "Profesor" || txtcbTipoUsuario.Text == "Administrativo") && CorreoValido(correo) == true)
                    {
                        errorIcono.Clear();
                        NUsuario.Insertar(this.txtMatricula.Text, this.txtNombre.Text, this.txtApellido.Text, this.txtcbCarrera.Text,this.txtcbSexo.Text, this.txtcbTipoUsuario.Text, correo, this.dtFechaIng.Value);
                        Limpiar();
                        MessageBox.Show("Registro guardado");
                    }
                    else{
                        MessageBox.Show("**Si eres un alumno tu matricula debe tener 9 digitos, Si eres profesor o administrativo debe tener 4 digitos" + Environment.NewLine + Environment.NewLine
                            + "**Comprueba que las matriculas ingresadas sean las correctas" + Environment.NewLine + Environment.NewLine
                            +"**Verifica que el correo electronico tenga un formato valido");
                        errorIcono.SetError(txtMatricula, "Verifica que los datos ingresados sean correctos");
                        errorIcono.SetError(txtRepetirMat, "Verifica que los datos ingresados sean correctos");
                        errorIcono.SetError(txtcbTipoUsuario, "Verifica que los datos ingresados sean correctos");
                        errorIcono.SetError(txtEmail, "Verifica que los datos ingresados sean correctos");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtMatricula.Text == string.Empty)
                {
                    errorIcono.SetError(txtMatricula, "Ingrese la matricula");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre");
                    errorIcono.SetError(txtApellido, "Ingrese apellido");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Realmente desea modificar el registro", "Modificar registro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        NUsuario.Editar(Convert.ToInt32(txtIdUser.Text), this.txtMatricula.Text, this.txtNombre.Text, this.txtApellido.Text, this.txtcbCarrera.Text,this.txtcbSexo.Text, this.txtcbTipoUsuario.Text, this.txtEmail.Text, this.dtFechaIng.Value);

                        MessageBox.Show("Registro modificado");
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

            if (rbMatricula.Checked == true)
            {

                SqlConnection SqlCon = new SqlConnection();
                SqlCon.ConnectionString = Conexion.ConexionDB;

                SqlCon.Open();

                try
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        errorIcono.SetError(txtBuscar, "Ingrese la matricula");
                    }
                    else
                    {
                        this.dataListado.DataSource = NUsuario.BuscarMatricula(this.txtBuscar.Text);

                        string SqlSelectQuery = "SELECT * FROM Usuarios WHERE matricula = " + (txtBuscar.Text);
                        SqlCommand cmd = new SqlCommand(SqlSelectQuery, SqlCon);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            txtIdUser.Text = (dr["idUsuario"].ToString());
                            txtMatricula.Text = (dr["matricula"].ToString());
                            txtNombre.Text = (dr["nombre"].ToString());
                            txtApellido.Text = (dr["apellidos"].ToString());
                            txtcbCarrera.Text = (dr["carrera"].ToString());
                            txtcbSexo.Text = (dr["sexo"].ToString());
                            txtcbTipoUsuario.Text = (dr["tipousuario"].ToString());
                            txtEmail.Text = (dr["email"].ToString());
                            dtFechaIng.Value = Convert.ToDateTime(dr["fechareg"].ToString());
                        }
                        SqlCon.Close();

                        //
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                this.dataListado.DataSource = NUsuario.BuscarNombreCompleto(this.txtBuscar.Text);
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdUser.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IdUsuario"].Value);
                this.txtMatricula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["matricula"].Value);
                this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                this.txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value);
                this.txtcbCarrera.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["carrera"].Value);
                this.txtcbSexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
                this.txtcbTipoUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipousuario"].Value);
                this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
                this.dtFechaIng.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fechareg"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            rbMatricula.Checked = true;
            txtMatricula.Select();

            /*
            if (CorreoValido("toto@gmailcom") == true)
            {
                MessageBox.Show("Mail Valido");
            }
            else
            {
                MessageBox.Show("Mail invalido");

            }*/
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.sololetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.sololetras(e);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbMatricula.Checked == true)
            {
                validaciones.solonumeros(e);
            }
            else
            {
                validaciones.sololetras(e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text == string.Empty)
                {
                    errorIcono.SetError(txtMatricula, "Ingrese matricula");
                }
                else
                {
                    DialogResult resul = MessageBox.Show("Realmente desea eliminar el registro", "Eliminar registro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        NUsuario.Eliminar(txtMatricula.Text);
                        Limpiar();
                        MessageBox.Show("Registro eliminado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtIdUser.Text = "";
            txtMatricula.Text = "";
            txtRepetirMat.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtcbCarrera.Text = "";
            txtcbSexo.Text = "";
            txtcbTipoUsuario.Text = "";
            txtEmail.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataListado.DataSource = NUsuario.BuscarMatricula(this.txtMatricula.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtRepetirMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumeros(e);
        }
    }
}
