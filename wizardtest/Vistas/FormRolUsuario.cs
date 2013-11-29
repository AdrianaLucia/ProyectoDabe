using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wizardtest.Vistas
{
    public partial class FormRolUsuario : Form
    {
        public FormRolUsuario()
        {
            InitializeComponent();
        }
        private void checkBoxVerInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxVerInfo.Checked)
            {
                checkBoxAdicionar.Checked = false;
                checkBoxModificar.Checked = false;
                checkBoxEliminar.Checked = false;
            }

        }
        private void checkBoxAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdicionar.Checked)
            {
                checkBoxVerInfo.Checked = true;
            }
            else
            {
                checkBoxModificar.Checked = false;
                checkBoxEliminar.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void refrescarGrid()
        {
            
            System.Data.DataTable t = Controlador.ControladorRolUsuario.getDataSetTodos();
            dataGridListaRoles.AutoGenerateColumns = true;
            dataGridListaRoles.DataSource = t;
            dataGridListaRoles.Columns[0].Visible = false;
            textBoxIdRol.Text = "";

        }

        private void checkBoxModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModificar.Checked)
            {
                checkBoxVerInfo.Checked = true;
                checkBoxAdicionar.Checked = true;
            }
            else
            {
                checkBoxEliminar.Checked = false;
            }
        }

        private void checkBoxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEliminar.Checked)
            {
                checkBoxVerInfo.Checked = true;
                checkBoxAdicionar.Checked = true;
                checkBoxModificar.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nivel = 0;
            if (checkBoxVerInfo.Checked) nivel = 1;
            if (checkBoxAdicionar.Checked) nivel = 2;
            if (checkBoxModificar.Checked) nivel = 3;
            if (checkBoxEliminar.Checked) nivel = 4;
            try {
                if (textBoxIdRol.Text != "" && textBoxNombre.Text != "") {//modificacion

                    int id = int.Parse(textBoxIdRol.Text);
                    Controlador.ControladorRolUsuario.modificar(id, textBoxNombre.Text, nivel);
                }
                else { //adicion
                    if (textBoxNombre.Text != "") {
                        
                        Controlador.ControladorRolUsuario.adicionar(textBoxNombre.Text, nivel);
                    }
                }
            } catch (Exception ex){
            }
            refrescarGrid();
        }

        private void dataGridListaRoles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIdRol.Text = dataGridListaRoles.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNombre.Text = dataGridListaRoles.Rows[e.RowIndex].Cells[1
                ].Value.ToString();
            int numPrivilegio = Int32.Parse(dataGridListaRoles.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (numPrivilegio > 0) checkBoxVerInfo.Checked = true;
            if (numPrivilegio > 1) checkBoxAdicionar.Checked = true;
            if (numPrivilegio > 2) checkBoxModificar.Checked = true;
            if (numPrivilegio > 3) checkBoxEliminar.Checked = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxIdRol.Text);
                Controlador.ControladorRolUsuario.eliminar(id);
            
            }
            catch (Exception ex)
            {
            }
            refrescarGrid();
        }

        private void FormRolUsuario_Load(object sender, EventArgs e)
        {
            refrescarGrid();
        }

       
    }
}
