namespace wizardtest
{
    partial class FormPrincipal
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
            this.btnGestionTipoActividad = new System.Windows.Forms.Button();
            this.buttonGestionEstadoActividad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRolUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionTipoActividad
            // 
            this.btnGestionTipoActividad.Location = new System.Drawing.Point(21, 89);
            this.btnGestionTipoActividad.Name = "btnGestionTipoActividad";
            this.btnGestionTipoActividad.Size = new System.Drawing.Size(190, 46);
            this.btnGestionTipoActividad.TabIndex = 3;
            this.btnGestionTipoActividad.Text = "Tipos de Actividades";
            this.btnGestionTipoActividad.UseVisualStyleBackColor = true;
            this.btnGestionTipoActividad.Click += new System.EventHandler(this.btnGestionTipoActividad_Click);
            // 
            // buttonGestionEstadoActividad
            // 
            this.buttonGestionEstadoActividad.Location = new System.Drawing.Point(21, 37);
            this.buttonGestionEstadoActividad.Name = "buttonGestionEstadoActividad";
            this.buttonGestionEstadoActividad.Size = new System.Drawing.Size(190, 46);
            this.buttonGestionEstadoActividad.TabIndex = 5;
            this.buttonGestionEstadoActividad.Text = "Estados de Actividades";
            this.buttonGestionEstadoActividad.UseVisualStyleBackColor = true;
            this.buttonGestionEstadoActividad.Click += new System.EventHandler(this.buttonGestionEstadoActividad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actividades";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonRolUsuario
            // 
            this.buttonRolUsuario.Location = new System.Drawing.Point(260, 37);
            this.buttonRolUsuario.Name = "buttonRolUsuario";
            this.buttonRolUsuario.Size = new System.Drawing.Size(190, 46);
            this.buttonRolUsuario.TabIndex = 7;
            this.buttonRolUsuario.Text = "Rol Usuario";
            this.buttonRolUsuario.UseVisualStyleBackColor = true;
            this.buttonRolUsuario.Click += new System.EventHandler(this.buttonRolUsuario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 46);
            this.button3.TabIndex = 9;
            this.button3.Text = "Estados de Estudiantes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "Periodos Academicos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Location = new System.Drawing.Point(260, 151);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(190, 46);
            this.btnEstudiantes.TabIndex = 11;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 46);
            this.button5.TabIndex = 12;
            this.button5.Text = "Actividades-Periodos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 46);
            this.button6.TabIndex = 13;
            this.button6.Text = "Carreras";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 364);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRolUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGestionEstadoActividad);
            this.Controls.Add(this.btnGestionTipoActividad);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionTipoActividad;
        private System.Windows.Forms.Button buttonGestionEstadoActividad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRolUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

