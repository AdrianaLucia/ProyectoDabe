namespace wizardtest.Vistas
{
    partial class FormPeriodoAcademico
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
            this.textBoxidEstadoActividad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEstados = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxidEstadoActividad
            // 
            this.textBoxidEstadoActividad.Enabled = false;
            this.textBoxidEstadoActividad.Location = new System.Drawing.Point(22, 46);
            this.textBoxidEstadoActividad.Name = "textBoxidEstadoActividad";
            this.textBoxidEstadoActividad.Size = new System.Drawing.Size(134, 20);
            this.textBoxidEstadoActividad.TabIndex = 22;
            this.textBoxidEstadoActividad.TextChanged += new System.EventHandler(this.textBoxidEstadoActividad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Año";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(22, 93);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(134, 20);
            this.txtAnio.TabIndex = 20;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEstado_KeyPress);
            this.txtAnio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEstado_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Periodos academicos";
            // 
            // dataGridViewEstados
            // 
            this.dataGridViewEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstados.Location = new System.Drawing.Point(206, 46);
            this.dataGridViewEstados.Name = "dataGridViewEstados";
            this.dataGridViewEstados.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEstados.TabIndex = 18;
            this.dataGridViewEstados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstados_RowEnter_1);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(288, 216);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 35);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(172, 216);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(100, 35);
            this.buttonModificar.TabIndex = 16;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(56, 216);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 35);
            this.buttonAdicionar.TabIndex = 15;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sigla del Semestre";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(22, 139);
            this.txtSigla.MaxLength = 10;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(134, 20);
            this.txtSigla.TabIndex = 23;
            // 
            // FormPeriodoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.textBoxidEstadoActividad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEstados);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAdicionar);
            this.Name = "FormPeriodoAcademico";
            this.Text = "FormPeriodoAcademico";
            this.Load += new System.EventHandler(this.FormEstadoActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxidEstadoActividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEstados;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigla;
    }
}