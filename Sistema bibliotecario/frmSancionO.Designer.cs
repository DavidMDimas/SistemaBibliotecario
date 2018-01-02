namespace Sistema_bibliotecario
{
    partial class frmSancionO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarreraSancion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreSancion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatriculaSancion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreoSancion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPagoSancion = new System.Windows.Forms.TextBox();
            this.txtDiasRetrasoSancion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaSancion = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.gbAdeudo = new System.Windows.Forms.GroupBox();
            this.lblAdeudo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEntrega = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.gbAdeudo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCarreraSancion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreSancion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMatriculaSancion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCorreoSancion);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 124);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(479, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 31);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(419, 27);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(92, 20);
            this.txtApellidos.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Carrera";
            // 
            // txtCarreraSancion
            // 
            this.txtCarreraSancion.Location = new System.Drawing.Point(57, 66);
            this.txtCarreraSancion.Name = "txtCarreraSancion";
            this.txtCarreraSancion.Size = new System.Drawing.Size(151, 20);
            this.txtCarreraSancion.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre";
            // 
            // txtNombreSancion
            // 
            this.txtNombreSancion.Location = new System.Drawing.Point(248, 28);
            this.txtNombreSancion.Name = "txtNombreSancion";
            this.txtNombreSancion.Size = new System.Drawing.Size(92, 20);
            this.txtNombreSancion.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Matricula";
            // 
            // txtMatriculaSancion
            // 
            this.txtMatriculaSancion.Location = new System.Drawing.Point(60, 28);
            this.txtMatriculaSancion.Name = "txtMatriculaSancion";
            this.txtMatriculaSancion.ShortcutsEnabled = false;
            this.txtMatriculaSancion.Size = new System.Drawing.Size(100, 20);
            this.txtMatriculaSancion.TabIndex = 27;
            this.txtMatriculaSancion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatriculaSancion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Correo";
            // 
            // txtCorreoSancion
            // 
            this.txtCorreoSancion.Location = new System.Drawing.Point(288, 66);
            this.txtCorreoSancion.Name = "txtCorreoSancion";
            this.txtCorreoSancion.Size = new System.Drawing.Size(107, 20);
            this.txtCorreoSancion.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Monto Final";
            // 
            // txtPagoSancion
            // 
            this.txtPagoSancion.Location = new System.Drawing.Point(508, 23);
            this.txtPagoSancion.Name = "txtPagoSancion";
            this.txtPagoSancion.Size = new System.Drawing.Size(68, 20);
            this.txtPagoSancion.TabIndex = 46;
            // 
            // txtDiasRetrasoSancion
            // 
            this.txtDiasRetrasoSancion.Location = new System.Drawing.Point(362, 23);
            this.txtDiasRetrasoSancion.Name = "txtDiasRetrasoSancion";
            this.txtDiasRetrasoSancion.Size = new System.Drawing.Size(46, 20);
            this.txtDiasRetrasoSancion.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Dias de retraso";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(724, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Registrar sancion";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fecha de expiracion";
            // 
            // txtFechaSancion
            // 
            this.txtFechaSancion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaSancion.Location = new System.Drawing.Point(137, 23);
            this.txtFechaSancion.Name = "txtFechaSancion";
            this.txtFechaSancion.Size = new System.Drawing.Size(101, 20);
            this.txtFechaSancion.TabIndex = 25;
            this.txtFechaSancion.ValueChanged += new System.EventHandler(this.txtFechaSancion_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFechaSancion);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPagoSancion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDiasRetrasoSancion);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 69);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adeudo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Referencia bancaria";
            // 
            // dataListado
            // 
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(12, 263);
            this.dataListado.Name = "dataListado";
            this.dataListado.Size = new System.Drawing.Size(649, 150);
            this.dataListado.TabIndex = 64;
            // 
            // gbAdeudo
            // 
            this.gbAdeudo.Controls.Add(this.lblAdeudo);
            this.gbAdeudo.Location = new System.Drawing.Point(683, 13);
            this.gbAdeudo.Name = "gbAdeudo";
            this.gbAdeudo.Size = new System.Drawing.Size(191, 100);
            this.gbAdeudo.TabIndex = 65;
            this.gbAdeudo.TabStop = false;
            this.gbAdeudo.Text = "Adeudo actual";
            // 
            // lblAdeudo
            // 
            this.lblAdeudo.AutoSize = true;
            this.lblAdeudo.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdeudo.Location = new System.Drawing.Point(19, 41);
            this.lblAdeudo.Name = "lblAdeudo";
            this.lblAdeudo.Size = new System.Drawing.Size(0, 24);
            this.lblAdeudo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Libros actuales";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtReferencia);
            this.groupBox4.Controls.Add(this.btnVerificar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(683, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 145);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(23, 48);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(168, 20);
            this.txtReferencia.TabIndex = 63;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(55, 81);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 30);
            this.btnVerificar.TabIndex = 62;
            this.btnVerificar.Text = "Verificar clave";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnEntrega
            // 
            this.btnEntrega.Enabled = false;
            this.btnEntrega.Location = new System.Drawing.Point(724, 205);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(100, 38);
            this.btnEntrega.TabIndex = 69;
            this.btnEntrega.Text = "Entregar";
            this.btnEntrega.UseVisualStyleBackColor = true;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // frmSancionO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 422);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbAdeudo);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSancionO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSancionO";
            this.Load += new System.EventHandler(this.frmSancionO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.gbAdeudo.ResumeLayout(false);
            this.gbAdeudo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPagoSancion;
        private System.Windows.Forms.TextBox txtDiasRetrasoSancion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreoSancion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarreraSancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreSancion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.GroupBox gbAdeudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtReferencia;
        public System.Windows.Forms.TextBox txtMatriculaSancion;
        private System.Windows.Forms.ErrorProvider errorIcono;
        public System.Windows.Forms.Label lblAdeudo;
        public System.Windows.Forms.DateTimePicker txtFechaSancion;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnBuscar;
    }
}