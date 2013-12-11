namespace wizardtest.Vistas
{
    partial class FormRegistroAsistencia
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
            this.dgActividades = new System.Windows.Forms.DataGridView();
            this.dgEstudiantesEnActividad = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantesEnActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgActividades
            // 
            this.dgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgActividades.Location = new System.Drawing.Point(21, 127);
            this.dgActividades.MultiSelect = false;
            this.dgActividades.Name = "dgActividades";
            this.dgActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgActividades.Size = new System.Drawing.Size(260, 262);
            this.dgActividades.TabIndex = 0;
            this.dgActividades.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgActividades_RowEnter);
            // 
            // dgEstudiantesEnActividad
            // 
            this.dgEstudiantesEnActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEstudiantesEnActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstudiantesEnActividad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEstudiantesEnActividad.Location = new System.Drawing.Point(287, 127);
            this.dgEstudiantesEnActividad.MultiSelect = false;
            this.dgEstudiantesEnActividad.Name = "dgEstudiantesEnActividad";
            this.dgEstudiantesEnActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstudiantesEnActividad.Size = new System.Drawing.Size(306, 262);
            this.dgEstudiantesEnActividad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actividades del Periodo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 24);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semana a registrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "SEMANA DE:";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.Location = new System.Drawing.Point(154, 54);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(20, 26);
            this.lblSemana.TabIndex = 7;
            this.lblSemana.Text = "-";
            // 
            // FormRegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 452);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEstudiantesEnActividad);
            this.Controls.Add(this.dgActividades);
            this.MaximumSize = new System.Drawing.Size(1023, 720);
            this.MinimumSize = new System.Drawing.Size(621, 490);
            this.Name = "FormRegistroAsistencia";
            this.Text = "FormRegistroAsistencia";
            this.Load += new System.EventHandler(this.FormRegistroAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantesEnActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgActividades;
        private System.Windows.Forms.DataGridView dgEstudiantesEnActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSemana;
    }
}