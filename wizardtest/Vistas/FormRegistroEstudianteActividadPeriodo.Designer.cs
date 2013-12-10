namespace wizardtest.Vistas
{
    partial class FormRegistroEstudianteActividadPeriodo
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
            this.dgActividadesPeriodo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEstudiantes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbActividadesPeriodo = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnGuardarLista = new System.Windows.Forms.Button();
            this.btnQuitarEstudianteSeleccionado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividadesPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgActividadesPeriodo
            // 
            this.dgActividadesPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividadesPeriodo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgActividadesPeriodo.Location = new System.Drawing.Point(12, 49);
            this.dgActividadesPeriodo.Name = "dgActividadesPeriodo";
            this.dgActividadesPeriodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgActividadesPeriodo.Size = new System.Drawing.Size(202, 209);
            this.dgActividadesPeriodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actividades";
            // 
            // dgEstudiantes
            // 
            this.dgEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstudiantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEstudiantes.Location = new System.Drawing.Point(244, 49);
            this.dgEstudiantes.Name = "dgEstudiantes";
            this.dgEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstudiantes.Size = new System.Drawing.Size(343, 209);
            this.dgEstudiantes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actividad";
            // 
            // cbActividadesPeriodo
            // 
            this.cbActividadesPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActividadesPeriodo.FormattingEnabled = true;
            this.cbActividadesPeriodo.Location = new System.Drawing.Point(15, 300);
            this.cbActividadesPeriodo.Name = "cbActividadesPeriodo";
            this.cbActividadesPeriodo.Size = new System.Drawing.Size(199, 21);
            this.cbActividadesPeriodo.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(244, 300);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(343, 109);
            this.dataGridView3.TabIndex = 5;
            // 
            // btnGuardarLista
            // 
            this.btnGuardarLista.Location = new System.Drawing.Point(15, 328);
            this.btnGuardarLista.Name = "btnGuardarLista";
            this.btnGuardarLista.Size = new System.Drawing.Size(199, 36);
            this.btnGuardarLista.TabIndex = 6;
            this.btnGuardarLista.Text = "Guardar Lista";
            this.btnGuardarLista.UseVisualStyleBackColor = true;
            // 
            // btnQuitarEstudianteSeleccionado
            // 
            this.btnQuitarEstudianteSeleccionado.Location = new System.Drawing.Point(15, 370);
            this.btnQuitarEstudianteSeleccionado.Name = "btnQuitarEstudianteSeleccionado";
            this.btnQuitarEstudianteSeleccionado.Size = new System.Drawing.Size(199, 23);
            this.btnQuitarEstudianteSeleccionado.TabIndex = 7;
            this.btnQuitarEstudianteSeleccionado.Text = "Quitar seleccionado";
            this.btnQuitarEstudianteSeleccionado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estudiantes no registrados en alguna actividad";
            // 
            // FormRegistroEstudianteActividadPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuitarEstudianteSeleccionado);
            this.Controls.Add(this.btnGuardarLista);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.cbActividadesPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgEstudiantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgActividadesPeriodo);
            this.Name = "FormRegistroEstudianteActividadPeriodo";
            this.Text = "FormRegistroEstudianteActividadPeriodo";
            this.Load += new System.EventHandler(this.FormRegistroEstudianteActividadPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActividadesPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgActividadesPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEstudiantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbActividadesPeriodo;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnGuardarLista;
        private System.Windows.Forms.Button btnQuitarEstudianteSeleccionado;
        private System.Windows.Forms.Label label3;
    }
}