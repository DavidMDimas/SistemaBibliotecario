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
    public partial class frmReportes : Form
    {

        public frmReportes()
        {
            InitializeComponent();
        }

        private void LimpiarChart()
        {
            foreach (var series in chartUsuarios.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chartLibros.Series)
            {
                series.Points.Clear();
            }
        }

        private void CargarGeneralUsuarios()
        {
            int alMasculinos = Convert.ToInt32(NReportes.MostrarAlumnoMasculinoGeneral().Rows.Count);
            int alFemeninos = Convert.ToInt32(NReportes.MostrarAlumnoFemeninoGeneral().Rows.Count);

            int profMasculinos = Convert.ToInt32(NReportes.MostrarProfesorMasculinoGeneral().Rows.Count);
            int profFemeninos = Convert.ToInt32(NReportes.MostrarProfesorFemeninoGeneral().Rows.Count);

            int admMasculinos = Convert.ToInt32(NReportes.MostrarAdmMasculinoGeneral().Rows.Count);
            int admFemeninos = Convert.ToInt32(NReportes.MostrarAdmFemeninoGeneral().Rows.Count);

            int totalUsuarios = alMasculinos + alFemeninos + profMasculinos + profFemeninos + admMasculinos + admFemeninos;

            this.chartUsuarios.Series["Usuarios"].Points.AddXY("Administrativo", (admMasculinos + admFemeninos));
            this.chartUsuarios.Series["Masculino"].Points.AddXY("Administrativo", admMasculinos);
            this.chartUsuarios.Series["Femenino"].Points.AddXY("Administrativo", admFemeninos);

            this.chartUsuarios.Series["Usuarios"].Points.AddXY("Alumnos/Egresados", (alMasculinos + alFemeninos));
            this.chartUsuarios.Series["Masculino"].Points.AddXY("Alumnos/Egresados", alMasculinos);
            this.chartUsuarios.Series["Femenino"].Points.AddXY("Alumnos/Egresados", alFemeninos);

            this.chartUsuarios.Series["Usuarios"].Points.AddXY("Docente", (profMasculinos + profFemeninos));
            this.chartUsuarios.Series["Masculino"].Points.AddXY("Docente", profMasculinos);
            this.chartUsuarios.Series["Femenino"].Points.AddXY("Docente", profFemeninos);

            txtTotalUsuarios.Text = Convert.ToString(totalUsuarios);
            txtTAlumnos.Text = Convert.ToString((alMasculinos + alFemeninos));
            txtTDocentes.Text = Convert.ToString((profMasculinos + profFemeninos));
            txtTAdministrativos.Text = Convert.ToString((admMasculinos + admFemeninos));

        }

        private void CargarGeneralLibros()
        {
            int totalLibros = Convert.ToInt32(NReportes.MostrarLibrosGeneral().Rows.Count);
            this.chartLibros.Series["Libros"].Points.AddXY("Total", totalLibros);

            txtTotalLibros.Text = Convert.ToString(totalLibros);
        }

        private void CargarDatosUsuarios(DateTime dt1,DateTime dt2)
        {
            int alMasculinos = Convert.ToInt32(NReportes.AlumnosMasculinos(dt1, dt2).Rows.Count);
            int alFemeninos = Convert.ToInt32(NReportes.AlumnosFemeninos(dt1, dt2).Rows.Count);

            int profMasculinos = Convert.ToInt32(NReportes.ProfesoresMasculinos(dt1, dt2).Rows.Count);
            int profFemeninos = Convert.ToInt32(NReportes.ProfesoresFemeninos(dt1, dt2).Rows.Count);

            int admMasculinos = Convert.ToInt32(NReportes.AdministrativosMasculinos(dt1, dt2).Rows.Count);
            int admFemeninos = Convert.ToInt32(NReportes.AdministrativosFemeninos(dt1, dt2).Rows.Count);

            int totalUsuarios = alMasculinos + alFemeninos + profMasculinos + profFemeninos + admMasculinos + admFemeninos;

            this.chartUsuarios.Series["Usuarios"].Points.AddXY("Administrativo", (admMasculinos + admFemeninos));
            this.chartUsuarios.Series["Masculino"].Points.AddXY("Administrativo", admMasculinos);
            this.chartUsuarios.Series["Femenino"].Points.AddXY("Administrativo", admFemeninos);

            this.chartUsuarios.Series["Usuarios"].Points.AddXY("Alumnos/Egresados", (alMasculinos + alFemeninos));
            this.chartUsuarios.Series["Masculino"].Points.AddXY("Alumnos/Egresados", alMasculinos);
            this.chartUsuarios.Series["Femenino"].Points.AddXY("Alumnos/Egresados", alFemeninos);

            this.chartUsuarios.Series["Usuarios"].Points.AddXY("Docente", (profMasculinos + profFemeninos));
            this.chartUsuarios.Series["Masculino"].Points.AddXY("Docente", profMasculinos);
            this.chartUsuarios.Series["Femenino"].Points.AddXY("Docente", profFemeninos);

            txtTotalUsuarios.Text = Convert.ToString(totalUsuarios);
            txtTAlumnos.Text = Convert.ToString((alMasculinos + alFemeninos));
            txtTDocentes.Text = Convert.ToString((profMasculinos + profFemeninos));
            txtTAdministrativos.Text = Convert.ToString((admMasculinos + admFemeninos));
        }

        private void CargarLibros(DateTime dt1, DateTime dt2)
        {
            int totalLibros= Convert.ToInt32(NReportes.LibrosTotales(dt1, dt2).Rows.Count);
            this.chartLibros.Series["Libros"].Points.AddXY("Total",totalLibros);
            txtTotalLibros.Text = Convert.ToString(totalLibros);
        }

        private void dtFecha1_CloseUp(object sender, EventArgs e)
        {
            if (dtFecha1.Value > dtFecha2.Value)
            {
                MessageBox.Show("Error, la fecha inicial no puede ser mayor a la final");
                dtFecha1.Value = DateTime.Now.Date;
                dtFecha2.Value = DateTime.Now.Date;
            }
        }

        private void dtFecha2_CloseUp(object sender, EventArgs e)
        {
            try
            {
                if (dtFecha1.Value > dtFecha2.Value)
                {
                    MessageBox.Show("Error, la fecha inicial no puede ser mayor a la final");
                    dtFecha1.Value = DateTime.Now.Date;
                    dtFecha2.Value = DateTime.Now.Date;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            LimpiarChart();

            CargarDatosUsuarios(dtFecha1.Value, dtFecha2.Value);
            CargarLibros(dtFecha1.Value, dtFecha2.Value);
                //chartUsuarios.Series.Clear();
                //chartUsuarios.Dispose();
                //chartUsuarios.Series.RemoveAt(0);
                //LimpiarChart();
            
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarGeneralUsuarios();
            CargarGeneralLibros();
        }

        private void btnGenerarTodo_Click(object sender, EventArgs e)
        {
            LimpiarChart();
            CargarGeneralUsuarios();
            CargarGeneralLibros();
        }
    }
}
