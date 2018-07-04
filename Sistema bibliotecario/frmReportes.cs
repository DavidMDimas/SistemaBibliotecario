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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Threading;

namespace Sistema_bibliotecario
{
    public partial class frmReportes : Form
    {

        bool Pulsado=true;

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

            chartUsuarios.Series.Clear();
            this.chartUsuarios.Series.Add("Usuarios");
            this.chartUsuarios.Series.Add("Masculino");
            this.chartUsuarios.Series.Add("Femenino");

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

            txtTotalMasc.Text = Convert.ToString(alMasculinos + profMasculinos + admMasculinos);
            txtTotalFem.Text= Convert.ToString(alFemeninos + profFemeninos + admFemeninos);

            txtAlMasc.Text = Convert.ToString(alMasculinos);
            txtAlFem.Text = Convert.ToString(alFemeninos);

            txtAdmMasc.Text = Convert.ToString(admMasculinos);
            txtAdmFem.Text = Convert.ToString(admFemeninos);

            txtProfMasc.Text = Convert.ToString(profMasculinos);
            txtProfFem.Text = Convert.ToString(profFemeninos);

        }

        private void CargarGeneralLibros()
        {
            chartLibros.Series.Clear();
            int totalLibros = Convert.ToInt32(NReportes.MostrarLibrosGeneral().Rows.Count);
            this.chartLibros.Series.Add("Libros");
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

            chartUsuarios.Series.Clear();
            this.chartUsuarios.Series.Add("Usuarios");
            this.chartUsuarios.Series.Add("Masculino");
            this.chartUsuarios.Series.Add("Femenino");

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

            txtTotalMasc.Text = Convert.ToString(alMasculinos + profMasculinos + admMasculinos);
            txtTotalFem.Text = Convert.ToString(alFemeninos + profFemeninos + admFemeninos);

            txtAlMasc.Text = Convert.ToString(alMasculinos);
            txtAlFem.Text = Convert.ToString(alFemeninos);

            txtAdmMasc.Text = Convert.ToString(admMasculinos);
            txtAdmFem.Text = Convert.ToString(admFemeninos);

            txtProfMasc.Text = Convert.ToString(profMasculinos);
            txtProfFem.Text = Convert.ToString(profFemeninos);
        }

        private void CargarLibros(DateTime dt1, DateTime dt2)
        {
            chartLibros.Series.Clear();
            int totalLibros= Convert.ToInt32(NReportes.LibrosTotales(dt1, dt2).Rows.Count);

            this.chartLibros.Series.Add("Libros");
            this.chartLibros.Series["Libros"].Points.AddXY("Total",totalLibros);
            txtTotalLibros.Text = Convert.ToString(totalLibros);
        }

        private void EncabezadoPDF(Document document, iTextSharp.text.Font _ef, iTextSharp.text.Font _sf, PdfPTable table)
        {
            // Encabezado
            iTextSharp.text.Image logoTesi = iTextSharp.text.Image.GetInstance("./Resources/tesilogo.png");
            logoTesi.BorderWidth = 0;
            logoTesi.Alignment = Element.ALIGN_LEFT;
            float porcentaje = .0f;
            porcentaje = 80 / logoTesi.Width;
            logoTesi.ScalePercent(porcentaje * 100);
            logoTesi.SetAbsolutePosition(480, 715);

            iTextSharp.text.Image logoEdoMex = iTextSharp.text.Image.GetInstance("./Resources/tesiedomex.png");
            logoEdoMex.BorderWidth = 0;
            logoEdoMex.Alignment = Element.ALIGN_RIGHT;
            porcentaje = 80 / logoEdoMex.Width;
            logoEdoMex.ScalePercent(porcentaje * 100);
            logoEdoMex.SetAbsolutePosition(50, 700);

            document.Add(logoEdoMex);
            document.Add(logoTesi);

            Paragraph tesi = new Paragraph("Tecnológico de estudios superiores de Ixtapaluca", _ef);
            Paragraph titulo = new Paragraph("Biblioteca escolar", _ef);
            Paragraph tema = new Paragraph("Formato de reportes", _ef);

            tesi.Alignment = Element.ALIGN_CENTER;
            titulo.Alignment = Element.ALIGN_CENTER;
            tema.Alignment = Element.ALIGN_CENTER;

            document.Add(tesi);
            document.Add(titulo);
            document.Add(tema);
            document.Add(Chunk.NEWLINE);

            Paragraph fechaActual = new Paragraph(Convert.ToString(DateTime.Now.ToLongDateString()), _sf);
            fechaActual.Alignment = Element.ALIGN_LEFT;
            document.Add(fechaActual);

            document.Add(Chunk.NEWLINE);

            if (Origen(Pulsado) == 0)
            {
                //Generar sin fecha
                Phrase fecha = new Phrase("Fecha: ", _sf);
                /*Phrase fechaIntervalo1 = new Phrase(Convert.ToString(dtFecha1.Value.ToString("dd/mm/yyyy")), _sf);
                Phrase fechaIntervalo2 = new Phrase("-" + Convert.ToString(dtFecha2.Value.ToString("dd/mm/yyyy")), _sf);*/

                Phrase fechaIntervalo1 = new Phrase(Convert.ToString(dtFecha1.Value.ToString(   )), _sf);
                Phrase fechaIntervalo2 = new Phrase("-" + Convert.ToString(dtFecha2.Value.ToString()), _sf);

                document.Add(fecha);
                document.Add(fechaIntervalo1);
                document.Add(fechaIntervalo2);
                document.Add(Chunk.NEWLINE);
            }
            //document.Add(table);

        }

        private int Origen(bool pulsa)
        {
            if (pulsa)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void TotalUsuarios(Document document, iTextSharp.text.Font _tf)
        {
            Paragraph usuariosTotal = new Paragraph("Total de usuarios: "+txtTotalUsuarios.Text, _tf);
            Paragraph alumnos = new Paragraph("Alumnos: "+txtTAlumnos.Text, _tf);
            Paragraph administrativos = new Paragraph("Administrativos: "+txtTAdministrativos.Text, _tf);
            Paragraph docentes = new Paragraph("Docentes: "+txtTDocentes.Text, _tf);

            usuariosTotal.Alignment = Element.ALIGN_CENTER;
            alumnos.Alignment = Element.ALIGN_CENTER;
            administrativos.Alignment = Element.ALIGN_CENTER;
            docentes.Alignment = Element.ALIGN_CENTER;

            document.Add(usuariosTotal);
            document.Add(alumnos);
            document.Add(administrativos);
            document.Add(docentes);
        }

        private void TotalLibros(Document document, iTextSharp.text.Font _tf)
        {
            Paragraph librosTotal = new Paragraph("Total de Libros: " + txtTotalLibros.Text, _tf);

            librosTotal.Alignment = Element.ALIGN_CENTER;

            document.Add(librosTotal);
        }

        private void AbrirCarpeta()
        {
            Process.Start(@"..\");
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
            try
            {
                Pulsado = false;
                Origen(Pulsado);
                LimpiarChart();

                CargarDatosUsuarios(dtFecha1.Value, dtFecha2.Value);
                CargarLibros(dtFecha1.Value, dtFecha2.Value);
                    //chartUsuarios.Series.Clear();
                    //chartUsuarios.Dispose();
                    //chartUsuarios.Series.RemoveAt(0);
                    //LimpiarChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }


        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                //Process.Start(@"\");
                Carga carga = new Carga();
                Thread th = new Thread(new ThreadStart(carga.CargaForm));

                th.Start();
                th.Join();

                CargarGeneralUsuarios();
                CargarGeneralLibros();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGenerarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarChart();
                CargarGeneralUsuarios();
                CargarGeneralLibros();
                Pulsado = true;
                Origen(Pulsado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private PdfPTable TablaUsuarios(string nombre, iTextSharp.text.Font _tf, iTextSharp.text.Font _sf)
        {
            MemoryStream memoryStream = new MemoryStream();
            chartUsuarios.SaveImage(memoryStream, ChartImageFormat.Png);
            iTextSharp.text.Image chartU = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
            chartU.Alignment = Element.ALIGN_CENTER;
            chartU.ScalePercent(50f);
            memoryStream.Flush();

            PdfPTable tabla = new PdfPTable(3);
            

            Paragraph p1NP = new Paragraph("N.P.", _sf);
            Paragraph p2Act = new Paragraph("Actividad", _sf);
            Paragraph p3Res = new Paragraph("Resultados", _sf);

            PdfPCell celdaNP = new PdfPCell(new Phrase("N.P.", _sf));
            celdaNP.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            /*celdaNP.PaddingTop = -7;
            //celdaNP.AddElement(p1NP);
            celdaNP.Colspan = 3;
            celdaNP.HorizontalAlignment = PdfPCell.ALIGN_CENTER;*/

            PdfPCell celdaActividad = new PdfPCell(new Phrase("Actividad", _sf));
            celdaActividad.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            PdfPCell celdaResultados = new PdfPCell(new Phrase("Resultados", _sf));
            celdaResultados.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            //encabezado
            tabla.AddCell(celdaNP);
            tabla.AddCell(celdaActividad);
            tabla.AddCell(celdaResultados);

            //Contenido N.P.
            Paragraph pNombre = new Paragraph(nombre, _sf);
            pNombre.Alignment= Element.ALIGN_CENTER;

            //Contenido grafica
            PdfPCell celdaChart = new PdfPCell();
            celdaChart.AddElement(chartU);
            celdaChart.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            //float[] medidas = { 0.55f, 2.25f, 0.55f};
            float[] medidas = { 0.55f, 2.25f, 1.55f };


            Paragraph usuariosTotal = new Paragraph("Total de usuarios: " + txtTotalUsuarios.Text, _tf);
            Paragraph usuariosMasculinos = new Paragraph("Masculinos: " + txtTAlumnos.Text, _tf);
            Paragraph usuariosFemeninos= new Paragraph("Femeninos: " + txtTAlumnos.Text, _tf);

            Paragraph alumnos = new Paragraph("Alumnos: " + txtTAlumnos.Text, _tf);
            Paragraph alumnoMasc = new Paragraph("Masculinos: " + txtAlMasc.Text, _tf);
            Paragraph alumnoFem = new Paragraph("Femeninos: " + txtAlFem.Text, _tf);

            Paragraph administrativos = new Paragraph("Administrativos: " + txtTAdministrativos.Text, _tf);
            Paragraph admMasc = new Paragraph("Masculinos: " + txtAdmMasc.Text, _tf);
            Paragraph admFem = new Paragraph("Femeninos: " + txtAdmFem.Text, _tf);

            Paragraph docentes = new Paragraph("Docentes: " + txtTDocentes.Text, _tf);
            Paragraph profMasc = new Paragraph("Masculinos: " + txtProfMasc.Text, _tf);
            Paragraph profFem = new Paragraph("Femeninos: " + txtProfFem.Text, _tf);

            usuariosTotal.Alignment = Element.ALIGN_CENTER;
            usuariosMasculinos.Alignment = Element.ALIGN_CENTER;
            usuariosFemeninos.Alignment = Element.ALIGN_CENTER;

            alumnos.Alignment = Element.ALIGN_CENTER;
            alumnoMasc.Alignment = Element.ALIGN_CENTER;
            alumnoFem.Alignment = Element.ALIGN_CENTER;

            administrativos.Alignment = Element.ALIGN_CENTER;
            admMasc.Alignment = Element.ALIGN_CENTER;
            admFem.Alignment = Element.ALIGN_CENTER;

            docentes.Alignment = Element.ALIGN_CENTER;
            profMasc.Alignment = Element.ALIGN_CENTER;
            profFem.Alignment = Element.ALIGN_CENTER;

            PdfPCell celdaRes = new PdfPCell();
            //celdaRes.PaddingTop = -7;

            celdaRes.AddElement(usuariosTotal);
            celdaRes.AddElement(usuariosMasculinos);
            celdaRes.AddElement(usuariosFemeninos);
            celdaRes.AddElement(Chunk.NEWLINE);

            celdaRes.AddElement(alumnos);
            celdaRes.AddElement(alumnoMasc);
            celdaRes.AddElement(alumnoFem);
            celdaRes.AddElement(Chunk.NEWLINE);

            celdaRes.AddElement(administrativos);
            celdaRes.AddElement(admMasc);
            celdaRes.AddElement(alumnoFem);
            celdaRes.AddElement(Chunk.NEWLINE);

            celdaRes.AddElement(docentes);
            celdaRes.AddElement(profMasc);
            celdaRes.AddElement(profFem);
            celdaRes.AddElement(Chunk.NEWLINE);

            //celdaRes.Colspan = 3;
            celdaRes.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            tabla.AddCell(pNombre);
            tabla.AddCell(celdaChart);
            tabla.AddCell(celdaRes);

            /*
            tabla.AddCell(pNombre);
            tabla.AddCell(celdaChart);
            tabla.AddCell(celdaRes);*/

            tabla.SetWidths(medidas);
            return tabla;
        }

        private PdfPTable TablaLibros(string nombre, iTextSharp.text.Font _tf, iTextSharp.text.Font _sf)
        {
            PdfPTable tabla = new PdfPTable(3);

            MemoryStream memoryStream = new MemoryStream();
            chartLibros.SaveImage(memoryStream, ChartImageFormat.Png);
            iTextSharp.text.Image chartL = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
            chartL.Alignment = Element.ALIGN_CENTER;
            chartL.ScalePercent(45f);
            memoryStream.Flush();

            Paragraph p1NP = new Paragraph("N.P.", _sf);
            Paragraph p2Act = new Paragraph("Actividad", _sf);
            Paragraph p3Res = new Paragraph("Resultados", _sf);

            PdfPCell celdaNP = new PdfPCell(new Phrase("N.P.", _sf));
            celdaNP.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            PdfPCell celdaActividad = new PdfPCell(new Phrase("Actividad", _sf));
            celdaActividad.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            PdfPCell celdaResultados = new PdfPCell(new Phrase("Resultados", _sf));
            celdaResultados.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            //encabezado
            tabla.AddCell(celdaNP);
            tabla.AddCell(celdaActividad);
            tabla.AddCell(celdaResultados);

            //Contenido N.P.
            Paragraph pNombre = new Paragraph(nombre, _sf);
            pNombre.Alignment = Element.ALIGN_CENTER;

            //Contenido grafica
            PdfPCell celdaChart = new PdfPCell();
            celdaChart.AddElement(chartL);
            celdaChart.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            
            float[] medidas = { 0.55f, 2.25f, 1.55f };

            Paragraph librosTotal = new Paragraph("Total de libros: " + txtTotalLibros.Text, _tf);

            librosTotal.Alignment = Element.ALIGN_CENTER;

            PdfPCell celdaRes = new PdfPCell();
            //celdaRes.PaddingTop = -7;
            celdaRes.AddElement(Chunk.NEWLINE);
            celdaRes.AddElement(Chunk.NEWLINE);
            celdaRes.AddElement(librosTotal);
            celdaRes.AddElement(Chunk.NEWLINE);
            //celdaRes.Colspan = 3;
            celdaRes.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            tabla.AddCell(pNombre);
            tabla.AddCell(celdaChart);
            tabla.AddCell(celdaRes);

            tabla.SetWidths(medidas);

            return tabla;
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.LETTER);

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"..\reportebiblioteca.pdf", FileMode.Create));

                doc.AddTitle("Reportes");
                doc.AddCreator("Juan Mora");

                doc.Open();

                // Fuentes
                iTextSharp.text.Font _encabezadoFuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14f, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK);
                iTextSharp.text.Font _estandarFuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font _totalesFuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                PdfPTable tabla = new PdfPTable(3);
                
                //********************ENCABEZADO
                EncabezadoPDF(doc, _encabezadoFuente, _estandarFuente,tabla);

                /*
                Phrase p1 = new Phrase("Hola Juanito",_encabezadoFuente);
                Phrase p2 = new Phrase(" Mora", _standardFont);
                doc.Add(p1);
                doc.Add(p2);*/

                switch (cbReporte.Text)
                {
                    case "General":
                        Phrase reporteG = new Phrase("Reporte " + cbReporte.Text, _estandarFuente);
                        doc.Add(reporteG);
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(Chunk.NEWLINE);

                        doc.Add(TablaUsuarios(cbReporte.Text,_totalesFuente, _estandarFuente));
                        //doc.Add(chartU);

                        doc.Add(Chunk.NEWLINE);
                        //TotalUsuarios(doc, _totalesFuente);
                        doc.NewPage();

                        EncabezadoPDF(doc, _encabezadoFuente, _estandarFuente,tabla);
                        doc.Add(TablaLibros(cbReporte.Text, _totalesFuente, _estandarFuente));
                        //TotalLibros(doc, _totalesFuente);

                        break;

                    case "Usuarios":
                        Phrase reporteU = new Phrase("Reporte de " + cbReporte.Text, _estandarFuente);
                        doc.Add(reporteU);

                        doc.Add(Chunk.NEWLINE);
                        doc.Add(Chunk.NEWLINE);

                        doc.Add(TablaUsuarios(cbReporte.Text, _totalesFuente, _estandarFuente));

                        //doc.Add(chartU);

                        doc.Add(Chunk.NEWLINE);
                        //TotalUsuarios(doc, _totalesFuente);

                        break;    case "Libros":
                        Phrase reporteL = new Phrase("Reporte de " + cbReporte.Text, _estandarFuente);
                        doc.Add(reporteL);

                        doc.Add(Chunk.NEWLINE);
                        doc.Add(Chunk.NEWLINE);

                        doc.Add(TablaLibros(cbReporte.Text, _totalesFuente, _estandarFuente));
                        //doc.Add(chartL);

                        doc.Add(Chunk.NEWLINE);
                        //TotalLibros(doc, _totalesFuente);

                        break;
                }                

                doc.Close();
                writer.Close();

                MessageBox.Show("Archivo creado correctamente");
                AbrirCarpeta();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Series.Add("Alumnos");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chart1.Series.Clear();
        }
    }
}
