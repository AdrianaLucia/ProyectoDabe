namespace wizardtest.Vistas
{
    partial class FormEstadoEstudiante
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
            this.textBoxidTipoActividad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.dataGridViewTipos = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxidTipoActividad
            // 
            this.textBoxidTipoActividad.Location = new System.Drawing.Point(38, 146);
            this.textBoxidTipoActividad.Name = "textBoxidTipoActividad";
            this.textBoxidTipoActividad.Size = new System.Drawing.Size(134, 20);
            this.textBoxidTipoActividad.TabIndex = 29;
            this.textBoxidTipoActividad.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estados de Estudiante";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(38, 89);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(134, 20);
            this.textBoxTipo.TabIndex = 27;
            // 
            // dataGridViewTipos
            // 
            this.dataGridViewTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipos.Location = new System.Drawing.Point(250, 44);
            this.dataGridViewTipos.Name = "dataGridViewTipos";
            this.dataGridViewTipos.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTipos.TabIndex = 25;
            this.dataGridViewTipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipos_CellContentClick);
            this.dataGridViewTipos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipos_RowEnter);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(332, 214);
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
            this.buttonModificar.Location = new System.Drawing.Point(216, 214);
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
            this.buttonAdicionar.Location = new System.Drawing.Point(100, 214);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 35);
            this.buttonAdicionar.TabIndex = 22;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Estado de Estudiante";
            // 
            // FormEstadoEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxidTipoActividad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.dataGridViewTipos);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAdicionar);
            this.Name = "FormEstadoEstudiante";
            this.Text = "FormEstadoEstudiante";
            this.Load += new System.EventHandler(this.FormEstadoEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxidTipoActividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.DataGridView dataGridViewTipos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label1;
    }
}