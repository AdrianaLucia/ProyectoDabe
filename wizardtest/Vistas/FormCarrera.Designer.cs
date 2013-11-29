namespace wizardtest.Vistas
{
    partial class FormCarrera
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
            this.textBoxidCarrera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreCarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgListaCarreras = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.textBoxCodCarrera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFacultad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxidCarrera
            // 
            this.textBoxidCarrera.Location = new System.Drawing.Point(25, 287);
            this.textBoxidCarrera.Name = "textBoxidCarrera";
            this.textBoxidCarrera.Size = new System.Drawing.Size(134, 20);
            this.textBoxidCarrera.TabIndex = 29;
            this.textBoxidCarrera.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Carreras";
            // 
            // textBoxNombreCarrera
            // 
            this.textBoxNombreCarrera.Location = new System.Drawing.Point(25, 126);
            this.textBoxNombreCarrera.Name = "textBoxNombreCarrera";
            this.textBoxNombreCarrera.Size = new System.Drawing.Size(134, 20);
            this.textBoxNombreCarrera.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre Carrera";
            // 
            // dgListaCarreras
            // 
            this.dgListaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaCarreras.Location = new System.Drawing.Point(281, 61);
            this.dgListaCarreras.Name = "dgListaCarreras";
            this.dgListaCarreras.Size = new System.Drawing.Size(293, 235);
            this.dgListaCarreras.TabIndex = 25;
            this.dgListaCarreras.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstados_RowEnter);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(368, 333);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 35);
            this.buttonEliminar.TabIndex = 24;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(252, 333);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(100, 35);
            this.buttonModificar.TabIndex = 23;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(136, 333);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 35);
            this.buttonAdicionar.TabIndex = 22;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // textBoxCodCarrera
            // 
            this.textBoxCodCarrera.Location = new System.Drawing.Point(25, 183);
            this.textBoxCodCarrera.Name = "textBoxCodCarrera";
            this.textBoxCodCarrera.Size = new System.Drawing.Size(134, 20);
            this.textBoxCodCarrera.TabIndex = 31;
            this.textBoxCodCarrera.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxCodCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Codigo Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Facultad";
            // 
            // comboBoxFacultad
            // 
            this.comboBoxFacultad.FormattingEnabled = true;
            this.comboBoxFacultad.Items.AddRange(new object[] {
            "Ingenieria",
            "Arquitectura",
            "Ciencias Empresariales",
            "Humanidades y Comunicacion",
            "Ciencias Juridicas y Sociales"});
            this.comboBoxFacultad.Location = new System.Drawing.Point(25, 248);
            this.comboBoxFacultad.Name = "comboBoxFacultad";
            this.comboBoxFacultad.Size = new System.Drawing.Size(128, 21);
            this.comboBoxFacultad.TabIndex = 43;
            // 
            // FormCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 392);
            this.Controls.Add(this.comboBoxFacultad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCodCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxidCarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListaCarreras);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAdicionar);
            this.Name = "FormCarrera";
            this.Text = "FormCarrera";
            this.Load += new System.EventHandler(this.FormCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxidCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListaCarreras;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBoxCodCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFacultad;
    }
}