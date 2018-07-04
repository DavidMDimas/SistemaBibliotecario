namespace Sistema_bibliotecario
{
    partial class frmBuscarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarLibro));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTitulo = new System.Windows.Forms.RadioButton();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbISBN = new System.Windows.Forms.RadioButton();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataBusqueda = new System.Windows.Forms.DataGridView();
            this.Buscador = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBusqueda)).BeginInit();
            this.Buscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(474, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTitulo);
            this.groupBox1.Controls.Add(this.rbAutor);
            this.groupBox1.Controls.Add(this.rbISBN);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 99);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de busqueda";
            // 
            // rbTitulo
            // 
            this.rbTitulo.AutoSize = true;
            this.rbTitulo.Location = new System.Drawing.Point(44, 44);
            this.rbTitulo.Name = "rbTitulo";
            this.rbTitulo.Size = new System.Drawing.Size(51, 17);
            this.rbTitulo.TabIndex = 2;
            this.rbTitulo.TabStop = true;
            this.rbTitulo.Text = "Titulo";
            this.rbTitulo.UseVisualStyleBackColor = true;
            this.rbTitulo.CheckedChanged += new System.EventHandler(this.rbTitulo_CheckedChanged);
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.Location = new System.Drawing.Point(44, 67);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(50, 17);
            this.rbAutor.TabIndex = 1;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = true;
            this.rbAutor.CheckedChanged += new System.EventHandler(this.rbAutor_CheckedChanged);
            // 
            // rbISBN
            // 
            this.rbISBN.AutoSize = true;
            this.rbISBN.Location = new System.Drawing.Point(44, 20);
            this.rbISBN.Name = "rbISBN";
            this.rbISBN.Size = new System.Drawing.Size(50, 17);
            this.rbISBN.TabIndex = 0;
            this.rbISBN.TabStop = true;
            this.rbISBN.Text = "ISBN";
            this.rbISBN.UseVisualStyleBackColor = true;
            this.rbISBN.CheckedChanged += new System.EventHandler(this.rbISBN_CheckedChanged);
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(9, 56);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(251, 20);
            this.txtBusqueda.TabIndex = 30;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Busqueda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(474, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataBusqueda
            // 
            this.dataBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBusqueda.Location = new System.Drawing.Point(13, 131);
            this.dataBusqueda.Name = "dataBusqueda";
            this.dataBusqueda.Size = new System.Drawing.Size(558, 319);
            this.dataBusqueda.TabIndex = 33;
            this.dataBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBusqueda_CellDoubleClick);
            // 
            // Buscador
            // 
            this.Buscador.Controls.Add(this.label1);
            this.Buscador.Controls.Add(this.txtBusqueda);
            this.Buscador.Location = new System.Drawing.Point(172, 13);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(269, 100);
            this.Buscador.TabIndex = 34;
            this.Buscador.TabStop = false;
            this.Buscador.Text = "Buscador";
            // 
            // frmBuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 462);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.dataBusqueda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Libro";
            this.Load += new System.EventHandler(this.frmBuscarLibro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBusqueda)).EndInit();
            this.Buscador.ResumeLayout(false);
            this.Buscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTitulo;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbISBN;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataBusqueda;
        private System.Windows.Forms.GroupBox Buscador;
    }
}