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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarLibro));
            this.ckbISBN = new System.Windows.Forms.CheckBox();
            this.cbkTitulo = new System.Windows.Forms.CheckBox();
            this.cbkAutor = new System.Windows.Forms.CheckBox();
            this.cbkEditorial = new System.Windows.Forms.CheckBox();
            this.cbkTag = new System.Windows.Forms.CheckBox();
            this.cbkCodigoBarras = new System.Windows.Forms.CheckBox();
            this.cbkMateria = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbISBN
            // 
            this.ckbISBN.AutoSize = true;
            this.ckbISBN.Location = new System.Drawing.Point(19, 32);
            this.ckbISBN.Name = "ckbISBN";
            this.ckbISBN.Size = new System.Drawing.Size(54, 17);
            this.ckbISBN.TabIndex = 7;
            this.ckbISBN.Text = "ISBN:";
            this.ckbISBN.UseVisualStyleBackColor = true;
            // 
            // cbkTitulo
            // 
            this.cbkTitulo.AutoSize = true;
            this.cbkTitulo.Location = new System.Drawing.Point(19, 59);
            this.cbkTitulo.Name = "cbkTitulo";
            this.cbkTitulo.Size = new System.Drawing.Size(55, 17);
            this.cbkTitulo.TabIndex = 8;
            this.cbkTitulo.Text = "Titulo:";
            this.cbkTitulo.UseVisualStyleBackColor = true;
            // 
            // cbkAutor
            // 
            this.cbkAutor.AutoSize = true;
            this.cbkAutor.Location = new System.Drawing.Point(19, 86);
            this.cbkAutor.Name = "cbkAutor";
            this.cbkAutor.Size = new System.Drawing.Size(54, 17);
            this.cbkAutor.TabIndex = 9;
            this.cbkAutor.Text = "Autor:";
            this.cbkAutor.UseVisualStyleBackColor = true;
            // 
            // cbkEditorial
            // 
            this.cbkEditorial.AutoSize = true;
            this.cbkEditorial.Location = new System.Drawing.Point(19, 114);
            this.cbkEditorial.Name = "cbkEditorial";
            this.cbkEditorial.Size = new System.Drawing.Size(66, 17);
            this.cbkEditorial.TabIndex = 10;
            this.cbkEditorial.Text = "Editorial:";
            this.cbkEditorial.UseVisualStyleBackColor = true;
            // 
            // cbkTag
            // 
            this.cbkTag.AutoSize = true;
            this.cbkTag.Location = new System.Drawing.Point(19, 141);
            this.cbkTag.Name = "cbkTag";
            this.cbkTag.Size = new System.Drawing.Size(48, 17);
            this.cbkTag.TabIndex = 11;
            this.cbkTag.Text = "Tag:";
            this.cbkTag.UseVisualStyleBackColor = true;
            // 
            // cbkCodigoBarras
            // 
            this.cbkCodigoBarras.AutoSize = true;
            this.cbkCodigoBarras.Location = new System.Drawing.Point(19, 166);
            this.cbkCodigoBarras.Name = "cbkCodigoBarras";
            this.cbkCodigoBarras.Size = new System.Drawing.Size(109, 17);
            this.cbkCodigoBarras.TabIndex = 12;
            this.cbkCodigoBarras.Text = "Codigo de barras:";
            this.cbkCodigoBarras.UseVisualStyleBackColor = true;
            // 
            // cbkMateria
            // 
            this.cbkMateria.AutoSize = true;
            this.cbkMateria.Location = new System.Drawing.Point(19, 193);
            this.cbkMateria.Name = "cbkMateria";
            this.cbkMateria.Size = new System.Drawing.Size(64, 17);
            this.cbkMateria.TabIndex = 13;
            this.cbkMateria.Text = "Materia:";
            this.cbkMateria.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 20);
            this.textBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(127, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(338, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(338, 20);
            this.textBox4.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(127, 191);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(338, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // frmBuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbkMateria);
            this.Controls.Add(this.cbkCodigoBarras);
            this.Controls.Add(this.cbkTag);
            this.Controls.Add(this.cbkEditorial);
            this.Controls.Add(this.cbkAutor);
            this.Controls.Add(this.cbkTitulo);
            this.Controls.Add(this.ckbISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Libro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbISBN;
        private System.Windows.Forms.CheckBox cbkTitulo;
        private System.Windows.Forms.CheckBox cbkAutor;
        private System.Windows.Forms.CheckBox cbkEditorial;
        private System.Windows.Forms.CheckBox cbkTag;
        private System.Windows.Forms.CheckBox cbkCodigoBarras;
        private System.Windows.Forms.CheckBox cbkMateria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}