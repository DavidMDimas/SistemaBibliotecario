namespace Sistema_bibliotecario
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtcbAutor = new System.Windows.Forms.ComboBox();
            this.txtcbLengua = new System.Windows.Forms.ComboBox();
            this.txtcbEdicion = new System.Windows.Forms.ComboBox();
            this.txtdpFechaEdicion = new System.Windows.Forms.DateTimePicker();
            this.txtcbEditorial = new System.Windows.Forms.ComboBox();
            this.txtNPaginas = new System.Windows.Forms.TextBox();
            this.txtcbPublicacion = new System.Windows.Forms.ComboBox();
            this.txtcbMateria = new System.Windows.Forms.ComboBox();
            this.txtcbGenero = new System.Windows.Forms.ComboBox();
            this.txtcbSubgenero = new System.Windows.Forms.ComboBox();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnUpImagen = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnGuardarCodeBar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgUpload = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor/es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lengua de publicacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edición:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publicación:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Materia/s:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Editorial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "N° de paginas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha edición:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "ISBN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Genero:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Subgenero:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Disponibilidad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(343, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Ubicación:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Comentarios:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "TAG:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Código de barras:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(74, 58);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(244, 20);
            this.txtTitulo.TabIndex = 20;
            // 
            // txtcbAutor
            // 
            this.txtcbAutor.FormattingEnabled = true;
            this.txtcbAutor.Items.AddRange(new object[] {
            "MANUEL LOPEZ",
            "LISA ABEND",
            "MARCOS AGUINIS"});
            this.txtcbAutor.Location = new System.Drawing.Point(400, 27);
            this.txtcbAutor.Name = "txtcbAutor";
            this.txtcbAutor.Size = new System.Drawing.Size(211, 21);
            this.txtcbAutor.TabIndex = 21;
            // 
            // txtcbLengua
            // 
            this.txtcbLengua.FormattingEnabled = true;
            this.txtcbLengua.Items.AddRange(new object[] {
            "    Afrikaans",
            "    Albanian",
            "    Arabic",
            "    Belarusian",
            "    Bulgarian",
            "    Catalan",
            "    Chinese",
            "    Croatian",
            "    Czech",
            "    Danish",
            "    Dutch",
            "    English",
            "    Estonian",
            "    Finnish",
            "    French",
            "    Galicia",
            "    German",
            "    Greek",
            "    Haitian Creole",
            "    Hebrew",
            "    Hindi",
            "    Hungarian",
            "    Icelandic",
            "    Indonesian",
            "    Irish",
            "    Italian",
            "    Japanese",
            "    Korean",
            "    Latvian",
            "    Lithuanian",
            "    Macedonian",
            "    Malay",
            "    Maltese",
            "    Norwegian",
            "    Persian",
            "    Philippines",
            "    Polish",
            "    Portuguese",
            "    Romanian",
            "    Russian",
            "    Serbian",
            "    Slovak",
            "    Slovenian",
            "    Spanish",
            "    Swahili",
            "    Swedish",
            "    Thai",
            "    Turkish",
            "    Ukrainian",
            "    Vietnamese",
            "    Welsh",
            "    Yiddish"});
            this.txtcbLengua.Location = new System.Drawing.Point(139, 93);
            this.txtcbLengua.Name = "txtcbLengua";
            this.txtcbLengua.Size = new System.Drawing.Size(179, 21);
            this.txtcbLengua.TabIndex = 22;
            this.txtcbLengua.Text = "Español";
            // 
            // txtcbEdicion
            // 
            this.txtcbEdicion.FormattingEnabled = true;
            this.txtcbEdicion.Items.AddRange(new object[] {
            "1º \tPrimero",
            "2º \tSegundo",
            "3º \tTercero",
            "4º \tCuarto",
            "5º \tQuinto",
            "6º \tSexto",
            "7º \tSéptimo",
            "8º \tOctavo",
            "9º \tNoveno",
            "10º \tDécimo",
            "11º \tUndécimo",
            "12º \tDuodécimo",
            "13º \tDecimotercero",
            "14º \tDecimocuarto",
            "15º \tDecimoquinto",
            "16º \tDecimosexto",
            "17º \tDecimoséptimo",
            "18º \tDecimoctavo",
            "19º \tDecimonoveno",
            "20º \tVigésimo",
            "21º \tVigésimo primero",
            "22º \tVigésimo segundo",
            "23º \tVigésimo tercero",
            "24º \tVigésimo cuarto",
            "25º \tVigésimo quinto",
            "26º \tVigésimo sexto",
            "27º \tVigésimo séptimo",
            "28º \tVigésimo octavo",
            "29º \tVigésimo noveno",
            "30º \tTrigésimo",
            "40º \tCuadragésimo",
            "50º \tQuincuagésimo",
            "60º \tSexagésimo",
            "70º \tSeptuagésimo",
            "80º \tOctogésimo",
            "90º \tNonagésimo",
            "100º \tCentésimo"});
            this.txtcbEdicion.Location = new System.Drawing.Point(400, 93);
            this.txtcbEdicion.Name = "txtcbEdicion";
            this.txtcbEdicion.Size = new System.Drawing.Size(211, 21);
            this.txtcbEdicion.TabIndex = 23;
            this.txtcbEdicion.Text = "1º \tPrimero";
            // 
            // txtdpFechaEdicion
            // 
            this.txtdpFechaEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdpFechaEdicion.Location = new System.Drawing.Point(426, 63);
            this.txtdpFechaEdicion.Name = "txtdpFechaEdicion";
            this.txtdpFechaEdicion.Size = new System.Drawing.Size(185, 20);
            this.txtdpFechaEdicion.TabIndex = 24;
            this.txtdpFechaEdicion.ValueChanged += new System.EventHandler(this.txtdpFechaEdicion_ValueChanged);
            // 
            // txtcbEditorial
            // 
            this.txtcbEditorial.FormattingEnabled = true;
            this.txtcbEditorial.Location = new System.Drawing.Point(74, 122);
            this.txtcbEditorial.Name = "txtcbEditorial";
            this.txtcbEditorial.Size = new System.Drawing.Size(244, 21);
            this.txtcbEditorial.TabIndex = 25;
            // 
            // txtNPaginas
            // 
            this.txtNPaginas.Location = new System.Drawing.Point(426, 127);
            this.txtNPaginas.Name = "txtNPaginas";
            this.txtNPaginas.Size = new System.Drawing.Size(185, 20);
            this.txtNPaginas.TabIndex = 26;
            this.txtNPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPaginas_KeyPress);
            // 
            // txtcbPublicacion
            // 
            this.txtcbPublicacion.FormattingEnabled = true;
            this.txtcbPublicacion.Location = new System.Drawing.Point(411, 258);
            this.txtcbPublicacion.Name = "txtcbPublicacion";
            this.txtcbPublicacion.Size = new System.Drawing.Size(200, 21);
            this.txtcbPublicacion.TabIndex = 28;
            this.txtcbPublicacion.Visible = false;
            this.txtcbPublicacion.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // txtcbMateria
            // 
            this.txtcbMateria.FormattingEnabled = true;
            this.txtcbMateria.Items.AddRange(new object[] {
            "Arquitectura y construcción",
            "Arte creativo y diseño",
            "Ciencias puras y aplicadas",
            "Ciencias sociales y de la comunicación",
            "Computación y tecnologías de la informacion",
            "Derecho",
            "Educación y formación",
            "Humanidades",
            "Ingeniería",
            "MBA",
            "Negocios y administración",
            "Peluquería, belleza y cuidado personal",
            "Salud y medicina",
            "Turismo y hospitalidad"});
            this.txtcbMateria.Location = new System.Drawing.Point(404, 157);
            this.txtcbMateria.Name = "txtcbMateria";
            this.txtcbMateria.Size = new System.Drawing.Size(207, 21);
            this.txtcbMateria.TabIndex = 29;
            this.txtcbMateria.Text = "Negocios y administración";
            // 
            // txtcbGenero
            // 
            this.txtcbGenero.FormattingEnabled = true;
            this.txtcbGenero.Items.AddRange(new object[] {
            "Lírica",
            "Épica o narrativa",
            "Drama",
            "Novela",
            "Policial (o Thriller)",
            "Romántica",
            "Aventura",
            "Terror",
            "Ficcion / Realidad",
            "Ciencia Ficción",
            "Investigación",
            "Biográfica",
            "Infantil",
            "Autoayuda",
            "Erótica",
            "Hogar",
            "Enciclopedia / Manual",
            "Política",
            "Economía / Marketing",
            "Sociedad",
            "Deportes",
            "Viajes / Cultura",
            "Otros temas / Varios"});
            this.txtcbGenero.Location = new System.Drawing.Point(86, 157);
            this.txtcbGenero.Name = "txtcbGenero";
            this.txtcbGenero.Size = new System.Drawing.Size(232, 21);
            this.txtcbGenero.TabIndex = 30;
            this.txtcbGenero.Text = "Investigación";
            // 
            // txtcbSubgenero
            // 
            this.txtcbSubgenero.FormattingEnabled = true;
            this.txtcbSubgenero.Items.AddRange(new object[] {
            "Oda",
            "Elegía",
            "Égloga",
            "Sátira",
            "Canción",
            "Epopeya",
            "Poema épico",
            "Romance",
            "Cuento",
            "Novela",
            "Tragedia",
            "Comedia",
            "Drama",
            "Ópera",
            "Zarzuela",
            "Otro"});
            this.txtcbSubgenero.Location = new System.Drawing.Point(411, 190);
            this.txtcbSubgenero.Name = "txtcbSubgenero";
            this.txtcbSubgenero.Size = new System.Drawing.Size(200, 21);
            this.txtcbSubgenero.TabIndex = 31;
            this.txtcbSubgenero.Text = "Otro";
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(96, 193);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(222, 20);
            this.txtDisponibilidad.TabIndex = 32;
            this.txtDisponibilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisponibilidadKeyPress);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(411, 226);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(200, 20);
            this.txtUbicacion.TabIndex = 33;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(96, 225);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(222, 86);
            this.txtComentarios.TabIndex = 34;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(36, 79);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(200, 20);
            this.txtTag.TabIndex = 35;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(36, 35);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoBarras.TabIndex = 36;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(85, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(166, 31);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(85, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(166, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnUpImagen
            // 
            this.btnUpImagen.Location = new System.Drawing.Point(76, 161);
            this.btnUpImagen.Name = "btnUpImagen";
            this.btnUpImagen.Size = new System.Drawing.Size(97, 23);
            this.btnUpImagen.TabIndex = 42;
            this.btnUpImagen.Text = "Subir Imagen";
            this.btnUpImagen.UseVisualStyleBackColor = true;
            this.btnUpImagen.Click += new System.EventHandler(this.btnUpImagen_Click);
            // 
            // dataListado
            // 
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(12, 334);
            this.dataListado.Name = "dataListado";
            this.dataListado.Size = new System.Drawing.Size(1188, 150);
            this.dataListado.TabIndex = 43;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(4, 31);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 44;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.Location = new System.Drawing.Point(36, 105);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 100);
            this.panelResultado.TabIndex = 45;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(36, 227);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 46;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnGuardarCodeBar
            // 
            this.btnGuardarCodeBar.Enabled = false;
            this.btnGuardarCodeBar.Location = new System.Drawing.Point(161, 227);
            this.btnGuardarCodeBar.Name = "btnGuardarCodeBar";
            this.btnGuardarCodeBar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCodeBar.TabIndex = 47;
            this.btnGuardarCodeBar.Text = "Guardar";
            this.btnGuardarCodeBar.UseVisualStyleBackColor = true;
            this.btnGuardarCodeBar.Click += new System.EventHandler(this.btnGuardarCodeBar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtComentarios);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.txtDisponibilidad);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtcbSubgenero);
            this.groupBox1.Controls.Add(this.txtcbAutor);
            this.groupBox1.Controls.Add(this.txtcbGenero);
            this.groupBox1.Controls.Add(this.txtcbLengua);
            this.groupBox1.Controls.Add(this.txtcbMateria);
            this.groupBox1.Controls.Add(this.txtcbEdicion);
            this.groupBox1.Controls.Add(this.txtcbPublicacion);
            this.groupBox1.Controls.Add(this.txtdpFechaEdicion);
            this.groupBox1.Controls.Add(this.txtNPaginas);
            this.groupBox1.Controls.Add(this.txtcbEditorial);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 321);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(74, 23);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(244, 20);
            this.txtISBN.TabIndex = 35;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged_1);
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(4, 64);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 36;
            this.btnMostrar.Text = "Mostrar libros";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgUpload);
            this.groupBox2.Controls.Add(this.btnUpImagen);
            this.groupBox2.Location = new System.Drawing.Point(662, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 201);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // imgUpload
            // 
            this.imgUpload.Image = global::Sistema_bibliotecario.Properties.Resources.bookPrincipal;
            this.imgUpload.Location = new System.Drawing.Point(22, 26);
            this.imgUpload.Name = "imgUpload";
            this.imgUpload.Size = new System.Drawing.Size(203, 129);
            this.imgUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUpload.TabIndex = 37;
            this.imgUpload.TabStop = false;
            this.imgUpload.Click += new System.EventHandler(this.imgUpload_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMostrar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Location = new System.Drawing.Point(662, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 100);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelResultado);
            this.groupBox4.Controls.Add(this.txtTag);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtCodigoBarras);
            this.groupBox4.Controls.Add(this.btnGuardarCodeBar);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.btnGenerar);
            this.groupBox4.Location = new System.Drawing.Point(915, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 260);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TAG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Sistema_bibliotecario.Properties.Resources.tesilogi;
            this.pictureBox1.Location = new System.Drawing.Point(915, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnUpImagen;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Button btnGuardarCodeBar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMostrar;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.ComboBox txtcbLengua;
        public System.Windows.Forms.ComboBox txtcbEditorial;
        public System.Windows.Forms.ComboBox txtcbGenero;
        public System.Windows.Forms.TextBox txtISBN;
        public System.Windows.Forms.ComboBox txtcbAutor;
        public System.Windows.Forms.ComboBox txtcbEdicion;
        public System.Windows.Forms.DateTimePicker txtdpFechaEdicion;
        public System.Windows.Forms.TextBox txtNPaginas;
        public System.Windows.Forms.ComboBox txtcbPublicacion;
        public System.Windows.Forms.ComboBox txtcbMateria;
        public System.Windows.Forms.ComboBox txtcbSubgenero;
        public System.Windows.Forms.TextBox txtDisponibilidad;
        public System.Windows.Forms.TextBox txtUbicacion;
        public System.Windows.Forms.TextBox txtComentarios;
        public System.Windows.Forms.TextBox txtTag;
        public System.Windows.Forms.TextBox txtCodigoBarras;
        public System.Windows.Forms.PictureBox imgUpload;
    }
}