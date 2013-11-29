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
    public partial class FormCarrera : Form
    {
        public FormCarrera()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxCodCarrera.Text != "" && textBoxNombreCarrera.Text != "")
            {
                Controlador.ControladorCarrera.adicionar(textBoxNombreCarrera.Text, Int32.Parse(textBoxCodCarrera.Text),comboBoxFacultad.SelectedItem.ToString());
                llenarDataSet();
            }
        }




        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!textBoxidCarrera.Text.Equals(""))
            {

                Controlador.ControladorCarrera.eliminar(Int32.Parse(textBoxidCarrera.Text));
            }
            else
            {
                MessageBox.Show("No esta seleccionado ningun Estado Actividad");
            }
            llenarDataSet();
        }

        private void llenarDataSet()
        {
            System.Data.DataTable t = Controlador.ControladorCarrera.getDataSetTodos();
            dgListaCarreras.AutoGenerateColumns = true;
            dgListaCarreras.DataSource = t;
            dgListaCarreras.Columns[0].Visible = false;
            textBoxidCarrera.Text = "";
        }

        private void FormEstadoActividad_Load(object sender, EventArgs e)
        {
            llenarDataSet();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(textBoxidCarrera.Text, out id))
            {
                Controlador.ControladorCarrera.modificar(id, textBoxNombreCarrera.Text, Int32.Parse(textBoxCodCarrera.Text), comboBoxFacultad.SelectedItem.ToString());
                llenarDataSet();
                textBoxidCarrera.Clear();
            }
        }

        private void dataGridViewEstados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxidCarrera.Text = dgListaCarreras.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNombreCarrera.Text = dgListaCarreras.Rows[e.RowIndex].Cells[1
                ].Value.ToString();
            textBoxCodCarrera.Text = dgListaCarreras.Rows[e.RowIndex].Cells[2
                ].Value.ToString();
            comboBoxFacultad.SelectedItem = dgListaCarreras.Rows[e.RowIndex].Cells[3
                ].Value.ToString();
        }

        private void FormCarrera_Load(object sender, EventArgs e)
        {
            comboBoxFacultad.SelectedIndex = 0;
            comboBoxFacultad.DropDownStyle = ComboBoxStyle.DropDownList;

            llenarDataSet();
        }

    }
}
