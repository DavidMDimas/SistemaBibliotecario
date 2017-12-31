namespace Sistema_bibliotecario
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.txtTotalUsuarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTAlumnos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTAdministrativos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTDocentes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalLibros = new System.Windows.Forms.TextBox();
            this.cbReporte = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerarTodo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartUsuarios
            // 
            chartArea3.Name = "ChartArea1";
            this.chartUsuarios.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartUsuarios.Legends.Add(legend3);
            this.chartUsuarios.Location = new System.Drawing.Point(227, 12);
            this.chartUsuarios.Name = "chartUsuarios";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Usuarios";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Masculino";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Femenino";
            this.chartUsuarios.Series.Add(series5);
            this.chartUsuarios.Series.Add(series6);
            this.chartUsuarios.Series.Add(series7);
            this.chartUsuarios.Size = new System.Drawing.Size(425, 397);
            this.chartUsuarios.TabIndex = 7;
            this.chartUsuarios.Text = "chart1";
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha1.Location = new System.Drawing.Point(39, 57);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(101, 20);
            this.dtFecha1.TabIndex = 26;
            this.dtFecha1.CloseUp += new System.EventHandler(this.dtFecha1_CloseUp);
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha2.Location = new System.Drawing.Point(39, 122);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(101, 20);
            this.dtFecha2.TabIndex = 27;
            this.dtFecha2.CloseUp += new System.EventHandler(this.dtFecha2_CloseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha intervalo 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha intervalo 2";
            // 
            // chartLibros
            // 
            chartArea4.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartLibros.Legends.Add(legend4);
            this.chartLibros.Location = new System.Drawing.Point(681, 12);
            this.chartLibros.Name = "chartLibros";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Libros";
            this.chartLibros.Series.Add(series8);
            this.chartLibros.Size = new System.Drawing.Size(425, 397);
            this.chartLibros.TabIndex = 30;
            this.chartLibros.Text = "chart1";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(14, 161);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 31;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerarTodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.dtFecha1);
            this.groupBox1.Controls.Add(this.dtFecha2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 203);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas";
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(65, 108);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporte.TabIndex = 33;
            this.btnVerReporte.Text = "Ver reporte PDF";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            // 
            // txtTotalUsuarios
            // 
            this.txtTotalUsuarios.Location = new System.Drawing.Point(352, 409);
            this.txtTotalUsuarios.Name = "txtTotalUsuarios";
            this.txtTotalUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtTotalUsuarios.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Total de usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Alumnos";
            // 
            // txtTAlumnos
            // 
            this.txtTAlumnos.Location = new System.Drawing.Point(352, 440);
            this.txtTAlumnos.Name = "txtTAlumnos";
            this.txtTAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtTAlumnos.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Administrativos";
            // 
            // txtTAdministrativos
            // 
            this.txtTAdministrativos.Location = new System.Drawing.Point(352, 469);
            this.txtTAdministrativos.Name = "txtTAdministrativos";
            this.txtTAdministrativos.Size = new System.Drawing.Size(100, 20);
            this.txtTAdministrativos.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Docentes";
            // 
            // txtTDocentes
            // 
            this.txtTDocentes.Location = new System.Drawing.Point(352, 498);
            this.txtTDocentes.Name = "txtTDocentes";
            this.txtTDocentes.Size = new System.Drawing.Size(100, 20);
            this.txtTDocentes.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(768, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Total de libros";
            // 
            // txtTotalLibros
            // 
            this.txtTotalLibros.Location = new System.Drawing.Point(862, 427);
            this.txtTotalLibros.Name = "txtTotalLibros";
            this.txtTotalLibros.Size = new System.Drawing.Size(100, 20);
            this.txtTotalLibros.TabIndex = 42;
            // 
            // cbReporte
            // 
            this.cbReporte.FormattingEnabled = true;
            this.cbReporte.Items.AddRange(new object[] {
            "Todo",
            "Usuarios",
            "Libros"});
            this.cbReporte.Location = new System.Drawing.Point(39, 62);
            this.cbReporte.Name = "cbReporte";
            this.cbReporte.Size = new System.Drawing.Size(129, 21);
            this.cbReporte.TabIndex = 32;
            this.cbReporte.Text = "Todo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Generar reporte de";
            // 
            // btnGenerarTodo
            // 
            this.btnGenerarTodo.Location = new System.Drawing.Point(106, 161);
            this.btnGenerarTodo.Name = "btnGenerarTodo";
            this.btnGenerarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarTodo.TabIndex = 34;
            this.btnGenerarTodo.Text = "Ver Todo";
            this.btnGenerarTodo.UseVisualStyleBackColor = true;
            this.btnGenerarTodo.Click += new System.EventHandler(this.btnGenerarTodo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbReporte);
            this.groupBox2.Controls.Add(this.btnVerReporte);
            this.groupBox2.Location = new System.Drawing.Point(21, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 158);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar PDF";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalLibros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTDocentes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTAdministrativos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartLibros);
            this.Controls.Add(this.chartUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuarios;
        public System.Windows.Forms.DateTimePicker dtFecha1;
        public System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.TextBox txtTotalUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTAlumnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTAdministrativos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTDocentes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalLibros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbReporte;
        private System.Windows.Forms.Button btnGenerarTodo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}