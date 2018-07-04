namespace Sistema_bibliotecario
{
    partial class frmPrestamos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITORIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTORES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBuscarIsbn = new System.Windows.Forms.Button();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtdtSegundaRenovacion = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtdtPrimerRenovacion = new System.Windows.Forms.DateTimePicker();
            this.txtdtFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcbTipoprestamo = new System.Windows.Forms.ComboBox();
            this.lblISBN2 = new System.Windows.Forms.Label();
            this.lblISBN3 = new System.Windows.Forms.Label();
            this.lblISBN1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnSancion = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.txtFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.btnAbrirSanciones = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEstatus);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(947, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 111);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adeudo";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(33, 58);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(70, 24);
            this.lblEstatus.TabIndex = 1;
            this.lblEstatus.Text = "Estatus";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Estado del usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCarrera);
            this.groupBox1.Controls.Add(this.txtGrupo);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(94, 63);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ShortcutsEnabled = false;
            this.txtMatricula.Size = new System.Drawing.Size(123, 20);
            this.txtMatricula.TabIndex = 19;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(535, 62);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(132, 20);
            this.txtApellidos.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(480, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Apellidos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.comboBox1.Location = new System.Drawing.Point(333, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Matutino";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(766, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(726, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(535, 112);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(94, 113);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(183, 20);
            this.txtCarrera.TabIndex = 12;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(739, 62);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(102, 20);
            this.txtGrupo.TabIndex = 11;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(333, 62);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(132, 20);
            this.txtNombreCompleto.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(45, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(685, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Turno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // gbLibros
            // 
            this.gbLibros.Controls.Add(this.btnEliminarTodo);
            this.gbLibros.Controls.Add(this.btnEliminar);
            this.gbLibros.Controls.Add(this.dataListado);
            this.gbLibros.Controls.Add(this.txtObservaciones);
            this.gbLibros.Controls.Add(this.label17);
            this.gbLibros.Controls.Add(this.btnBuscarIsbn);
            this.gbLibros.Controls.Add(this.txtIsbn);
            this.gbLibros.Controls.Add(this.txtdtSegundaRenovacion);
            this.gbLibros.Controls.Add(this.label16);
            this.gbLibros.Controls.Add(this.txtdtPrimerRenovacion);
            this.gbLibros.Controls.Add(this.txtdtFechaPrestamo);
            this.gbLibros.Controls.Add(this.label15);
            this.gbLibros.Controls.Add(this.label10);
            this.gbLibros.Controls.Add(this.label14);
            this.gbLibros.Controls.Add(this.label9);
            this.gbLibros.Controls.Add(this.txtcbTipoprestamo);
            this.gbLibros.Location = new System.Drawing.Point(12, 230);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Size = new System.Drawing.Size(910, 285);
            this.gbLibros.TabIndex = 5;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "Solicitar Libros";
            this.gbLibros.Enter += new System.EventHandler(this.gbLibros_Enter);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(784, 64);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTodo.TabIndex = 78;
            this.btnEliminarTodo.Text = "Eliminar todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(784, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 69;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataListado
            // 
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.TITULO,
            this.EDITORIAL,
            this.AUTORES});
            this.dataListado.Location = new System.Drawing.Point(244, 129);
            this.dataListado.Name = "dataListado";
            this.dataListado.Size = new System.Drawing.Size(644, 150);
            this.dataListado.TabIndex = 65;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 200;
            // 
            // TITULO
            // 
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            this.TITULO.Width = 200;
            // 
            // EDITORIAL
            // 
            this.EDITORIAL.HeaderText = "EDITORIAL";
            this.EDITORIAL.Name = "EDITORIAL";
            // 
            // AUTORES
            // 
            this.AUTORES.HeaderText = "AUTORES";
            this.AUTORES.Name = "AUTORES";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(9, 135);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(208, 145);
            this.txtObservaciones.TabIndex = 67;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 66;
            this.label17.Text = "Observaciones:";
            // 
            // btnBuscarIsbn
            // 
            this.btnBuscarIsbn.Location = new System.Drawing.Point(533, 31);
            this.btnBuscarIsbn.Name = "btnBuscarIsbn";
            this.btnBuscarIsbn.Size = new System.Drawing.Size(84, 24);
            this.btnBuscarIsbn.TabIndex = 34;
            this.btnBuscarIsbn.Text = "Buscar";
            this.btnBuscarIsbn.UseVisualStyleBackColor = true;
            this.btnBuscarIsbn.Click += new System.EventHandler(this.btnBuscarIsbn_Click);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(373, 34);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ShortcutsEnabled = false;
            this.txtIsbn.Size = new System.Drawing.Size(132, 20);
            this.txtIsbn.TabIndex = 17;
            this.txtIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsbn_KeyPress);
            // 
            // txtdtSegundaRenovacion
            // 
            this.txtdtSegundaRenovacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdtSegundaRenovacion.Location = new System.Drawing.Point(656, 80);
            this.txtdtSegundaRenovacion.Name = "txtdtSegundaRenovacion";
            this.txtdtSegundaRenovacion.Size = new System.Drawing.Size(101, 20);
            this.txtdtSegundaRenovacion.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(530, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Segunda renovacion:";
            // 
            // txtdtPrimerRenovacion
            // 
            this.txtdtPrimerRenovacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdtPrimerRenovacion.Location = new System.Drawing.Point(403, 80);
            this.txtdtPrimerRenovacion.Name = "txtdtPrimerRenovacion";
            this.txtdtPrimerRenovacion.Size = new System.Drawing.Size(101, 20);
            this.txtdtPrimerRenovacion.TabIndex = 27;
            // 
            // txtdtFechaPrestamo
            // 
            this.txtdtFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdtFechaPrestamo.Location = new System.Drawing.Point(127, 81);
            this.txtdtFechaPrestamo.Name = "txtdtFechaPrestamo";
            this.txtdtFechaPrestamo.Size = new System.Drawing.Size(101, 20);
            this.txtdtFechaPrestamo.TabIndex = 26;
            this.txtdtFechaPrestamo.ValueChanged += new System.EventHandler(this.txtdtFechaPrestamo_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(273, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Primer renovacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "ISBN:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Fecha prestamo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tipo de prestamo:";
            // 
            // txtcbTipoprestamo
            // 
            this.txtcbTipoprestamo.FormattingEnabled = true;
            this.txtcbTipoprestamo.Items.AddRange(new object[] {
            "Domicilio",
            "Copias",
            "Especial",
            "Consulta"});
            this.txtcbTipoprestamo.Location = new System.Drawing.Point(127, 34);
            this.txtcbTipoprestamo.Name = "txtcbTipoprestamo";
            this.txtcbTipoprestamo.Size = new System.Drawing.Size(121, 21);
            this.txtcbTipoprestamo.TabIndex = 0;
            this.txtcbTipoprestamo.Text = "Consulta";
            // 
            // lblISBN2
            // 
            this.lblISBN2.AutoSize = true;
            this.lblISBN2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN2.Location = new System.Drawing.Point(996, 597);
            this.lblISBN2.Name = "lblISBN2";
            this.lblISBN2.Size = new System.Drawing.Size(0, 15);
            this.lblISBN2.TabIndex = 77;
            // 
            // lblISBN3
            // 
            this.lblISBN3.AutoSize = true;
            this.lblISBN3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN3.Location = new System.Drawing.Point(996, 630);
            this.lblISBN3.Name = "lblISBN3";
            this.lblISBN3.Size = new System.Drawing.Size(0, 15);
            this.lblISBN3.TabIndex = 76;
            // 
            // lblISBN1
            // 
            this.lblISBN1.AutoSize = true;
            this.lblISBN1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN1.Location = new System.Drawing.Point(996, 564);
            this.lblISBN1.Name = "lblISBN1";
            this.lblISBN1.Size = new System.Drawing.Size(0, 15);
            this.lblISBN1.TabIndex = 75;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(944, 630);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 15);
            this.label19.TabIndex = 74;
            this.label19.Text = "ISBN 3:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(944, 597);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 73;
            this.label13.Text = "ISBN 2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(944, 564);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 72;
            this.label12.Text = "ISBN 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(944, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "Libros solicitados";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEntrega);
            this.groupBox4.Controls.Add(this.btnSancion);
            this.groupBox4.Controls.Add(this.btnPrestamo);
            this.groupBox4.Location = new System.Drawing.Point(938, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 129);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Autorizar";
            // 
            // btnEntrega
            // 
            this.btnEntrega.Location = new System.Drawing.Point(37, 55);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(75, 23);
            this.btnEntrega.TabIndex = 33;
            this.btnEntrega.Text = "Entrega";
            this.btnEntrega.UseVisualStyleBackColor = true;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click_1);
            // 
            // btnSancion
            // 
            this.btnSancion.Enabled = false;
            this.btnSancion.Location = new System.Drawing.Point(37, 91);
            this.btnSancion.Name = "btnSancion";
            this.btnSancion.Size = new System.Drawing.Size(75, 23);
            this.btnSancion.TabIndex = 5;
            this.btnSancion.Text = "Sancion";
            this.btnSancion.UseVisualStyleBackColor = true;
            this.btnSancion.Click += new System.EventHandler(this.btnSancion_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Enabled = false;
            this.btnPrestamo.Location = new System.Drawing.Point(37, 19);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnPrestamo.TabIndex = 3;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(949, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Fecha Limite";
            // 
            // txtFechaLimite
            // 
            this.txtFechaLimite.Checked = false;
            this.txtFechaLimite.Enabled = false;
            this.txtFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaLimite.Location = new System.Drawing.Point(952, 153);
            this.txtFechaLimite.Name = "txtFechaLimite";
            this.txtFechaLimite.Size = new System.Drawing.Size(101, 20);
            this.txtFechaLimite.TabIndex = 32;
            this.txtFechaLimite.Value = new System.DateTime(2999, 12, 21, 3, 35, 0, 0);
            // 
            // btnAbrirSanciones
            // 
            this.btnAbrirSanciones.Location = new System.Drawing.Point(970, 197);
            this.btnAbrirSanciones.Name = "btnAbrirSanciones";
            this.btnAbrirSanciones.Size = new System.Drawing.Size(100, 38);
            this.btnAbrirSanciones.TabIndex = 69;
            this.btnAbrirSanciones.Text = "Abrir Sanciones actuales";
            this.btnAbrirSanciones.UseVisualStyleBackColor = true;
            this.btnAbrirSanciones.Click += new System.EventHandler(this.btnAbrirSanciones_Click);
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 535);
            this.Controls.Add(this.btnAbrirSanciones);
            this.Controls.Add(this.lblISBN2);
            this.Controls.Add(this.txtFechaLimite);
            this.Controls.Add(this.lblISBN3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblISBN1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbLibros);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrestamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrestamos_FormClosed);
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbLibros.ResumeLayout(false);
            this.gbLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.ComboBox txtcbTipoprestamo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtdtPrimerRenovacion;
        private System.Windows.Forms.DateTimePicker txtdtFechaPrestamo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBuscarIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.DateTimePicker txtdtSegundaRenovacion;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSancion;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblISBN3;
        private System.Windows.Forms.Label lblISBN1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblISBN2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker txtFechaLimite;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnAbrirSanciones;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDITORIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTORES;
    }
}