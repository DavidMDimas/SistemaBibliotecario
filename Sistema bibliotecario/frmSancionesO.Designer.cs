namespace Sistema_bibliotecario
{
    partial class frmSancionesO
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
            this.dataSancion = new System.Windows.Forms.DataGridView();
            this.btnEliminarS = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.errorIco = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSancion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSancion
            // 
            this.dataSancion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSancion.Location = new System.Drawing.Point(12, 253);
            this.dataSancion.Name = "dataSancion";
            this.dataSancion.Size = new System.Drawing.Size(849, 195);
            this.dataSancion.TabIndex = 0;
            this.dataSancion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSancion_CellContentClick);
            // 
            // btnEliminarS
            // 
            this.btnEliminarS.Location = new System.Drawing.Point(129, 26);
            this.btnEliminarS.Name = "btnEliminarS";
            this.btnEliminarS.Size = new System.Drawing.Size(100, 38);
            this.btnEliminarS.TabIndex = 72;
            this.btnEliminarS.Text = "Eliminar Sancion";
            this.btnEliminarS.UseVisualStyleBackColor = true;
            this.btnEliminarS.Click += new System.EventHandler(this.btnEliminarS_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(10, 89);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 38);
            this.btnModificar.TabIndex = 71;
            this.btnModificar.Text = "Modificar Sancion";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(129, 89);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 38);
            this.btnMostrar.TabIndex = 73;
            this.btnMostrar.Text = "Mostrar Sanciones";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "ID Prestamo";
            // 
            // txtIdPres
            // 
            this.txtIdPres.Location = new System.Drawing.Point(95, 122);
            this.txtIdPres.Name = "txtIdPres";
            this.txtIdPres.ShortcutsEnabled = false;
            this.txtIdPres.Size = new System.Drawing.Size(169, 20);
            this.txtIdPres.TabIndex = 85;
            this.txtIdPres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPres_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(93, 86);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ShortcutsEnabled = false;
            this.txtISBN.Size = new System.Drawing.Size(171, 20);
            this.txtISBN.TabIndex = 80;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Matricula";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(93, 52);
            this.txtMat.Name = "txtMat";
            this.txtMat.ShortcutsEnabled = false;
            this.txtMat.Size = new System.Drawing.Size(171, 20);
            this.txtMat.TabIndex = 79;
            this.txtMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMat_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "ID Sancion";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(93, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 20);
            this.txtID.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Numero de referencia";
            // 
            // txtNumR
            // 
            this.txtNumR.Location = new System.Drawing.Point(157, 163);
            this.txtNumR.Name = "txtNumR";
            this.txtNumR.Size = new System.Drawing.Size(107, 20);
            this.txtNumR.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(84, 199);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(180, 20);
            this.txtFecha.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Dias";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(82, 22);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Monto Final";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(83, 56);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(99, 20);
            this.txtMonto.TabIndex = 90;
            // 
            // errorIco
            // 
            this.errorIco.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(10, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 38);
            this.btnBuscar.TabIndex = 93;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(83, 89);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(99, 20);
            this.txtEstatus.TabIndex = 94;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(30, 93);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(42, 13);
            this.lblEstatus.TabIndex = 95;
            this.lblEstatus.Text = "Estatus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumR);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtMat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtIdPres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 233);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.lblEstatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEstatus);
            this.groupBox2.Controls.Add(this.txtDias);
            this.groupBox2.Location = new System.Drawing.Point(331, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 149);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estatus";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMostrar);
            this.groupBox3.Controls.Add(this.btnEliminarS);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Location = new System.Drawing.Point(577, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 149);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // frmSancionesO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 468);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataSancion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSancionesO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanciones";
            this.Load += new System.EventHandler(this.frmSancionesO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSancion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSancion;
        private System.Windows.Forms.Button btnEliminarS;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ErrorProvider errorIco;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}