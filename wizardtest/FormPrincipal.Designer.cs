﻿namespace wizardtest
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
            this.SuspendLayout();
            // 
            // btnGestionTipoActividad
            // 
            this.btnGestionTipoActividad.Location = new System.Drawing.Point(42, 204);
            this.btnGestionTipoActividad.Name = "btnGestionTipoActividad";
            this.btnGestionTipoActividad.Size = new System.Drawing.Size(190, 46);
            this.btnGestionTipoActividad.TabIndex = 3;
            this.btnGestionTipoActividad.Text = "Tipos de Actividades";
            this.btnGestionTipoActividad.UseVisualStyleBackColor = true;
            this.btnGestionTipoActividad.Click += new System.EventHandler(this.btnGestionTipoActividad_Click);
            // 
            // buttonGestionEstadoActividad
            // 
            this.buttonGestionEstadoActividad.Location = new System.Drawing.Point(42, 141);
            this.buttonGestionEstadoActividad.Name = "buttonGestionEstadoActividad";
            this.buttonGestionEstadoActividad.Size = new System.Drawing.Size(142, 37);
            this.buttonGestionEstadoActividad.TabIndex = 5;
            this.buttonGestionEstadoActividad.Text = "Estados de Actividades";
            this.buttonGestionEstadoActividad.UseVisualStyleBackColor = true;
            this.buttonGestionEstadoActividad.Click += new System.EventHandler(this.buttonGestionEstadoActividad_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonGestionEstadoActividad);
            this.Controls.Add(this.btnGestionTipoActividad);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionTipoActividad;
        private System.Windows.Forms.Button buttonGestionEstadoActividad;
    }
}
