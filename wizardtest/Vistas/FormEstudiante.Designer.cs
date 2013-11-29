namespace wizardtest.Vistas
{
    partial class FormEstudiante
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCrearNuevo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIdEstudiante = new System.Windows.Forms.TextBox();
            this.dataGridListaUsuarios = new System.Windows.Forms.DataGridView();
            this.comboBoxFacultad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegistroEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApPat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.cbCondicionEspecial = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboEstadoEstudiante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Guardar cambio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCrearNuevo
            // 
            this.btnCrearNuevo.Location = new System.Drawing.Point(121, 418);
            this.btnCrearNuevo.Name = "btnCrearNuevo";
            this.btnCrearNuevo.Size = new System.Drawing.Size(107, 23);
            this.btnCrearNuevo.TabIndex = 46;
            this.btnCrearNuevo.Text = "Crear nuevo";
            this.btnCrearNuevo.UseVisualStyleBackColor = true;
            this.btnCrearNuevo.Click += new System.EventHandler(this.btnCrearNuevo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "id";
            // 
            // textBoxIdEstudiante
            // 
            this.textBoxIdEstudiante.Enabled = false;
            this.textBoxIdEstudiante.Location = new System.Drawing.Point(118, 42);
            this.textBoxIdEstudiante.Name = "textBoxIdEstudiante";
            this.textBoxIdEstudiante.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdEstudiante.TabIndex = 44;
            // 
            // dataGridListaUsuarios
            // 
            this.dataGridListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaUsuarios.Location = new System.Drawing.Point(234, 12);
            this.dataGridListaUsuarios.Name = "dataGridListaUsuarios";
            this.dataGridListaUsuarios.Size = new System.Drawing.Size(475, 387);
            this.dataGridListaUsuarios.TabIndex = 43;
            this.dataGridListaUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListaUsuarios_RowEnter);
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
            this.comboBoxFacultad.Location = new System.Drawing.Point(6, 269);
            this.comboBoxFacultad.Name = "comboBoxFacultad";
            this.comboBoxFacultad.Size = new System.Drawing.Size(222, 21);
            this.comboBoxFacultad.TabIndex = 42;
            this.comboBoxFacultad.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultad_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Estado Estudiante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Condicion Especial";
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Items.AddRange(new object[] {
            "Nombre de primer docente de colegio?",
            "Nombre de primera mascota?",
            "Nombre de primer amigo?"});
            this.comboBoxCarrera.Location = new System.Drawing.Point(6, 310);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(222, 21);
            this.comboBoxCarrera.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Carrera";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Registro Estudiante";
            // 
            // textBoxRegistroEstudiante
            // 
            this.textBoxRegistroEstudiante.Location = new System.Drawing.Point(6, 184);
            this.textBoxRegistroEstudiante.Name = "textBoxRegistroEstudiante";
            this.textBoxRegistroEstudiante.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistroEstudiante.TabIndex = 31;
            this.textBoxRegistroEstudiante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegistroEstudiante_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellido Materno";
            // 
            // textBoxApMat
            // 
            this.textBoxApMat.Location = new System.Drawing.Point(6, 137);
            this.textBoxApMat.Name = "textBoxApMat";
            this.textBoxApMat.Size = new System.Drawing.Size(100, 20);
            this.textBoxApMat.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido Paterno";
            // 
            // textBoxApPat
            // 
            this.textBoxApPat.Location = new System.Drawing.Point(6, 88);
            this.textBoxApPat.Name = "textBoxApPat";
            this.textBoxApPat.Size = new System.Drawing.Size(100, 20);
            this.textBoxApPat.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(6, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 25;
            // 
            // cbCondicionEspecial
            // 
            this.cbCondicionEspecial.AutoSize = true;
            this.cbCondicionEspecial.Location = new System.Drawing.Point(9, 356);
            this.cbCondicionEspecial.Name = "cbCondicionEspecial";
            this.cbCondicionEspecial.Size = new System.Drawing.Size(66, 17);
            this.cbCondicionEspecial.TabIndex = 49;
            this.cbCondicionEspecial.Text = "Utilizada";
            this.cbCondicionEspecial.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Carrera";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboEstadoEstudiante
            // 
            this.comboEstadoEstudiante.FormattingEnabled = true;
            this.comboEstadoEstudiante.Items.AddRange(new object[] {
            "Ingenieria",
            "Arquitectura",
            "Ciencias Empresariales",
            "Humanidades y Comunicacion",
            "Ciencias Juridicas y Sociales"});
            this.comboEstadoEstudiante.Location = new System.Drawing.Point(6, 224);
            this.comboEstadoEstudiante.Name = "comboEstadoEstudiante";
            this.comboEstadoEstudiante.Size = new System.Drawing.Size(222, 21);
            this.comboEstadoEstudiante.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Facultad";
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 458);
            this.Controls.Add(this.comboEstadoEstudiante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCondicionEspecial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCrearNuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxIdEstudiante);
            this.Controls.Add(this.dataGridListaUsuarios);
            this.Controls.Add(this.comboBoxFacultad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCarrera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRegistroEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApMat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApPat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCrearNuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxIdEstudiante;
        private System.Windows.Forms.DataGridView dataGridListaUsuarios;
        private System.Windows.Forms.ComboBox comboBoxFacultad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegistroEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApPat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.CheckBox cbCondicionEspecial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEstadoEstudiante;
        private System.Windows.Forms.Label label6;
    }
}