namespace Sistema_bibliotecario
{
    partial class frmSancion
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
            this.components = new System.ComponentModel.Container();
            this.dataSanciones = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdSancion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTurnoSancion = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPagoSancion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMultaDiaSancion = new System.Windows.Forms.TextBox();
            this.txtDiasRetrasoSancion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreoSancion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGrupoSancion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarreraSancion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoAlSancion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreAlSancion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatriculaSancion = new System.Windows.Forms.TextBox();
            this.txtFechaSancion = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtBusquedaMatSancion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSanciones
            // 
            this.dataSanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSanciones.Location = new System.Drawing.Point(12, 256);
            this.dataSanciones.Name = "dataSanciones";
            this.dataSanciones.Size = new System.Drawing.Size(721, 172);
            this.dataSanciones.TabIndex = 0;
            this.dataSanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSanciones_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(471, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // txtIdSancion
            // 
            this.txtIdSancion.Enabled = false;
            this.txtIdSancion.Location = new System.Drawing.Point(78, 21);
            this.txtIdSancion.Name = "txtIdSancion";
            this.txtIdSancion.Size = new System.Drawing.Size(100, 20);
            this.txtIdSancion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtTurnoSancion);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPagoSancion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMultaDiaSancion);
            this.groupBox1.Controls.Add(this.txtDiasRetrasoSancion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCorreoSancion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGrupoSancion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCarreraSancion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidoAlSancion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreAlSancion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMatriculaSancion);
            this.groupBox1.Controls.Add(this.txtFechaSancion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdSancion);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(431, 192);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 52;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(471, 149);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTurnoSancion
            // 
            this.txtTurnoSancion.FormattingEnabled = true;
            this.txtTurnoSancion.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Otro"});
            this.txtTurnoSancion.Location = new System.Drawing.Point(71, 197);
            this.txtTurnoSancion.Name = "txtTurnoSancion";
            this.txtTurnoSancion.Size = new System.Drawing.Size(153, 21);
            this.txtTurnoSancion.TabIndex = 50;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(471, 104);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(471, 61);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 48;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Monto Final";
            // 
            // txtPagoSancion
            // 
            this.txtPagoSancion.Enabled = false;
            this.txtPagoSancion.Location = new System.Drawing.Point(308, 194);
            this.txtPagoSancion.Name = "txtPagoSancion";
            this.txtPagoSancion.Size = new System.Drawing.Size(68, 20);
            this.txtPagoSancion.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Multa por dia";
            // 
            // txtMultaDiaSancion
            // 
            this.txtMultaDiaSancion.Location = new System.Drawing.Point(308, 126);
            this.txtMultaDiaSancion.Name = "txtMultaDiaSancion";
            this.txtMultaDiaSancion.Size = new System.Drawing.Size(68, 20);
            this.txtMultaDiaSancion.TabIndex = 44;
            // 
            // txtDiasRetrasoSancion
            // 
            this.txtDiasRetrasoSancion.Location = new System.Drawing.Point(330, 159);
            this.txtDiasRetrasoSancion.Name = "txtDiasRetrasoSancion";
            this.txtDiasRetrasoSancion.Size = new System.Drawing.Size(46, 20);
            this.txtDiasRetrasoSancion.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Dias de retraso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fecha de expiracion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Correo";
            // 
            // txtCorreoSancion
            // 
            this.txtCorreoSancion.Location = new System.Drawing.Point(288, 55);
            this.txtCorreoSancion.Name = "txtCorreoSancion";
            this.txtCorreoSancion.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoSancion.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Grupo";
            // 
            // txtGrupoSancion
            // 
            this.txtGrupoSancion.Location = new System.Drawing.Point(288, 21);
            this.txtGrupoSancion.Name = "txtGrupoSancion";
            this.txtGrupoSancion.Size = new System.Drawing.Size(100, 20);
            this.txtGrupoSancion.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Turno";
            // 
            // txtCarreraSancion
            // 
            this.txtCarreraSancion.FormattingEnabled = true;
            this.txtCarreraSancion.Items.AddRange(new object[] {
            "Ing. Sistemas Computacionales",
            "Arquitectura",
            "Ing. Biomedica",
            "Ing. Electronica",
            "Ing. Informatica",
            "Lic. Administracion",
            "Ing. Ambiental"});
            this.txtCarreraSancion.Location = new System.Drawing.Point(71, 162);
            this.txtCarreraSancion.Name = "txtCarreraSancion";
            this.txtCarreraSancion.Size = new System.Drawing.Size(153, 21);
            this.txtCarreraSancion.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Apellidos";
            // 
            // txtApellidoAlSancion
            // 
            this.txtApellidoAlSancion.Location = new System.Drawing.Point(78, 126);
            this.txtApellidoAlSancion.Name = "txtApellidoAlSancion";
            this.txtApellidoAlSancion.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAlSancion.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre";
            // 
            // txtNombreAlSancion
            // 
            this.txtNombreAlSancion.Location = new System.Drawing.Point(78, 92);
            this.txtNombreAlSancion.Name = "txtNombreAlSancion";
            this.txtNombreAlSancion.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAlSancion.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Matricula";
            // 
            // txtMatriculaSancion
            // 
            this.txtMatriculaSancion.Location = new System.Drawing.Point(78, 58);
            this.txtMatriculaSancion.Name = "txtMatriculaSancion";
            this.txtMatriculaSancion.Size = new System.Drawing.Size(100, 20);
            this.txtMatriculaSancion.TabIndex = 27;
            // 
            // txtFechaSancion
            // 
            this.txtFechaSancion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaSancion.Location = new System.Drawing.Point(343, 92);
            this.txtFechaSancion.Name = "txtFechaSancion";
            this.txtFechaSancion.Size = new System.Drawing.Size(101, 20);
            this.txtFechaSancion.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(626, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(587, 208);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(95, 30);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar Todo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtBusquedaMatSancion
            // 
            this.txtBusquedaMatSancion.Location = new System.Drawing.Point(610, 33);
            this.txtBusquedaMatSancion.Name = "txtBusquedaMatSancion";
            this.txtBusquedaMatSancion.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaMatSancion.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(607, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Busqueda por matricula";
            // 
            // frmSancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 440);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBusquedaMatSancion);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataSanciones);
            this.Name = "frmSancion";
            this.Text = "Sanciones";
            this.Load += new System.EventHandler(this.frmSancion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSanciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtFechaSancion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSancion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreoSancion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGrupoSancion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtCarreraSancion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoAlSancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreAlSancion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatriculaSancion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPagoSancion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMultaDiaSancion;
        private System.Windows.Forms.TextBox txtDiasRetrasoSancion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox txtTurnoSancion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBusquedaMatSancion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
    }
}