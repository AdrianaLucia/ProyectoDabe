namespace wizardtest.Vistas
{
    partial class FormActividadPeriodo
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnCrearNuevo = new System.Windows.Forms.Button();
            this.dataGridListaActividadesEnPeriodo = new System.Windows.Forms.DataGridView();
            this.dataGridActividades = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaActividadesEnPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCrearNuevo
            // 
            this.btnCrearNuevo.Location = new System.Drawing.Point(16, 345);
            this.btnCrearNuevo.Name = "btnCrearNuevo";
            this.btnCrearNuevo.Size = new System.Drawing.Size(308, 23);
            this.btnCrearNuevo.TabIndex = 50;
            this.btnCrearNuevo.Text = "Agregar Actividad al Periodo";
            this.btnCrearNuevo.UseVisualStyleBackColor = true;
            this.btnCrearNuevo.Click += new System.EventHandler(this.btnCrearNuevo_Click);
            // 
            // dataGridListaActividadesEnPeriodo
            // 
            this.dataGridListaActividadesEnPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaActividadesEnPeriodo.Location = new System.Drawing.Point(388, 43);
            this.dataGridListaActividadesEnPeriodo.MultiSelect = false;
            this.dataGridListaActividadesEnPeriodo.Name = "dataGridListaActividadesEnPeriodo";
            this.dataGridListaActividadesEnPeriodo.ReadOnly = true;
            this.dataGridListaActividadesEnPeriodo.Size = new System.Drawing.Size(308, 287);
            this.dataGridListaActividadesEnPeriodo.TabIndex = 49;
            // 
            // dataGridActividades
            // 
            this.dataGridActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActividades.Location = new System.Drawing.Point(16, 43);
            this.dataGridActividades.MultiSelect = false;
            this.dataGridActividades.Name = "dataGridActividades";
            this.dataGridActividades.ReadOnly = true;
            this.dataGridActividades.Size = new System.Drawing.Size(308, 287);
            this.dataGridActividades.TabIndex = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(576, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Lista de actividades";
            // 
            // FormActividadPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridActividades);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCrearNuevo);
            this.Controls.Add(this.dataGridListaActividadesEnPeriodo);
            this.Name = "FormActividadPeriodo";
            this.Text = "FormActividadPeriodo";
            this.Load += new System.EventHandler(this.FormActividadPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaActividadesEnPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCrearNuevo;
        private System.Windows.Forms.DataGridView dataGridListaActividadesEnPeriodo;
        private System.Windows.Forms.DataGridView dataGridActividades;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}