using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_bibliotecario
{
    public partial class LoginAcceso : Form
    {
        private int veces = 0;
        const int NumeroIntentos = 3;

        public LoginAcceso()
        {
            InitializeComponent();

            try
            {
                IPHostEntry host;
                string localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                lblIP.Text = "IP del equipo: " + localIP;
                lblMachineName.Text = "" + Environment.MachineName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string claveSHA = this.generarClaveSHA1(this.txtPasswd.Text);
                if (comprobarUsuario(this.txtUser.Text, claveSHA))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {

                    veces = veces + 1;
                    if (veces < NumeroIntentos)
                    {
                        lblIntentos.Visible = true;
                        lblIntentos.Text = "Quedan " + (NumeroIntentos - veces) + " intentos";
                        txtPasswd.Text = "";
                        txtUser.Text = "";
                        return;
                    }
                    this.DialogResult = DialogResult.No;
                }
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private bool comprobarUsuario(string nombre, string clave)
        {

            SqlConnection cnn = null;

            try
            {
                SqlConnection SqlCon = new SqlConnection();
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCon.Open();

                System.Text.StringBuilder sel = new System.Text.StringBuilder();

                sel.Append("SELECT COUNT(*) FROM Administracion ");
                sel.Append("WHERE Nombre = @Nombre AND Clave = @Clave");

                SqlCommand cmd = new SqlCommand(sel.ToString(), SqlCon);

                cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Clave", SqlDbType.NVarChar, 40);

                cmd.Parameters["@Nombre"].Value = nombre;
                cmd.Parameters["@Clave"].Value = clave;

                int t = Convert.ToInt32(cmd.ExecuteScalar());

                SqlCon.Close();

                if (t == 0)
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al conectar a la base de datos: \n" +
                    ex.Message, "Comprobar usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Dispose();
                }
            }
            MenunPrincipal frmMenu = new MenunPrincipal();
            frmMenu.Show();
            Hide();
            return true;

        }
        private string generarClaveSHA1(string nombre)
        {
            try
            {

                UTF8Encoding enc = new UTF8Encoding();
                byte[] data = enc.GetBytes(nombre);
                byte[] result;

                SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
                result = sha.ComputeHash(data);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] < 16)
                    {
                        sb.Append("0");
                    }
                    sb.Append(result[i].ToString("x"));
                }

                return sb.ToString().ToUpper();
            }


            catch (Exception ex)
            {
                throw;
            }
        }

        private void LoginAcceso_Load(object sender, EventArgs e)
        {

        }

        private void TimeReloj_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
