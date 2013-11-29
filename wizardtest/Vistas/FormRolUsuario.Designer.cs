namespace wizardtest.Vistas
{
    partial class FormRolUsuario
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
            this.checkBoxVerInfo = new System.Windows.Forms.CheckBox();
            this.checkBoxAdicionar = new System.Windows.Forms.CheckBox();
            this.checkBoxModificar = new System.Windows.Forms.CheckBox();
            this.checkBoxEliminar = new System.Windows.Forms.CheckBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.dataGridListaRoles = new System.Windows.Forms.DataGridView();
            this.textBoxIdRol = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxVerInfo
            // 
            this.checkBoxVerInfo.AutoSize = true;
            this.checkBoxVerInfo.Location = new System.Drawing.Point(97, 139);
            this.checkBoxVerInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxVerInfo.Name = "checkBoxVerInfo";
            this.checkBoxVerInfo.Size = new System.Drawing.Size(112, 21);
            this.checkBoxVerInfo.TabIndex = 0;
            this.checkBoxVerInfo.Text = "Visualizacion";
            this.checkBoxVerInfo.UseVisualStyleBackColor = true;
            this.checkBoxVerInfo.CheckedChanged += new System.EventHandler(this.checkBoxVerInfo_CheckedChanged);
            // 
            // checkBoxAdicionar
            // 
            this.checkBoxAdicionar.AutoSize = true;
            this.checkBoxAdicionar.Location = new System.Drawing.Point(97, 167);
            this.checkBoxAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAdicionar.Name = "checkBoxAdicionar";
            this.checkBoxAdicionar.Size = new System.Drawing.Size(89, 21);
            this.checkBoxAdicionar.TabIndex = 1;
            this.checkBoxAdicionar.Text = "Adicionar";
            this.checkBoxAdicionar.UseVisualStyleBackColor = true;
            this.checkBoxAdicionar.CheckedChanged += new System.EventHandler(this.checkBoxAdicionar_CheckedChanged);
            // 
            // checkBoxModificar
            // 
            this.checkBoxModificar.AutoSize = true;
            this.checkBoxModificar.Location = new System.Drawing.Point(97, 196);
            this.checkBoxModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxModificar.Name = "checkBoxModificar";
            this.checkBoxModificar.Size = new System.Drawing.Size(87, 21);
            this.checkBoxModificar.TabIndex = 2;
            this.checkBoxModificar.Text = "Modificar";
            this.checkBoxModificar.UseVisualStyleBackColor = true;
            this.checkBoxModificar.CheckedChanged += new System.EventHandler(this.checkBoxModificar_CheckedChanged);
            // 
            // checkBoxEliminar
            // 
            this.checkBoxEliminar.AutoSize = true;
            this.checkBoxEliminar.Location = new System.Drawing.Point(97, 224);
            this.checkBoxEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEliminar.Name = "checkBoxEliminar";
            this.checkBoxEliminar.Size = new System.Drawing.Size(80, 21);
            this.checkBoxEliminar.TabIndex = 3;
            this.checkBoxEliminar.Text = "Eliminar";
            this.checkBoxEliminar.UseVisualStyleBackColor = true;
            this.checkBoxEliminar.CheckedChanged += new System.EventHandler(this.checkBoxEliminar_CheckedChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(131, 63);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(132, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(16, 66);
            this.lblRolNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(106, 17);
            this.lblRolNombre.TabIndex = 5;
            this.lblRolNombre.Text = "Nombre del Rol";
            this.lblRolNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridListaRoles
            // 
            this.dataGridListaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaRoles.Location = new System.Drawing.Point(325, 41);
            this.dataGridListaRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridListaRoles.Name = "dataGridListaRoles";
            this.dataGridListaRoles.Size = new System.Drawing.Size(415, 294);
            this.dataGridListaRoles.TabIndex = 6;
            this.dataGridListaRoles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListaRoles_RowEnter);
            // 
            // textBoxIdRol
            // 
            this.textBoxIdRol.Enabled = false;
            this.textBoxIdRol.Location = new System.Drawing.Point(131, 31);
            this.textBoxIdRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdRol.Name = "textBoxIdRol";
            this.textBoxIdRol.Size = new System.Drawing.Size(132, 22);
            this.textBoxIdRol.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(165, 299);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 36);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Guardar cambios";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 299);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormRolUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 372);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBoxIdRol);
            this.Controls.Add(this.dataGridListaRoles);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.checkBoxEliminar);
            this.Controls.Add(this.checkBoxModificar);
            this.Controls.Add(this.checkBoxAdicionar);
            this.Controls.Add(this.checkBoxVerInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRolUsuario";
            this.Text = "FormRolUsuario";
            this.Load += new System.EventHandler(this.FormRolUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxVerInfo;
        private System.Windows.Forms.CheckBox checkBoxAdicionar;
        private System.Windows.Forms.CheckBox checkBoxModificar;
        private System.Windows.Forms.CheckBox checkBoxEliminar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.DataGridView dataGridListaRoles;
        private System.Windows.Forms.TextBox textBoxIdRol;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEliminar;
    }
}