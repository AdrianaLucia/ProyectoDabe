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
    public partial class FormTipoActividad : Form
    {
        public FormTipoActividad()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Controlador.GestionTipoActividad.adicionar(textBoxTipo.Text);
            llenarDataSet();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!textBoxidTipoActividad.Text.Equals(""))
            {

                Controlador.GestionTipoActividad.eliminar(Int32.Parse(textBoxidTipoActividad.Text));
            }
            else
            {
                MessageBox.Show("No esta seleccionado ningun Tipo Actividad");
            }
            llenarDataSet();
            textBoxTipo.Clear();
        }

        private void FormTipoActividad_Load(object sender, EventArgs e)
        {
          
            llenarDataSet();
        }

        private void llenarDataSet()
        {
            System.Data.DataTable t = Controlador.GestionTipoActividad.getDataSetTodos();
            dataGridViewTipos.AutoGenerateColumns = true;
            dataGridViewTipos.DataSource = t;
            dataGridViewTipos.Columns[0].Visible = false;
            textBoxidTipoActividad.Text = "";
        }

        private void dataGridViewTipos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxidTipoActividad.Text = dataGridViewTipos.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTipo.Text = dataGridViewTipos.Rows[e.RowIndex].Cells[1
                ].Value.ToString();
        }

        private void dataGridViewTipos_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(textBoxidTipoActividad.Text,out id))
            {
                Controlador.GestionTipoActividad.modificar(id, textBoxTipo.Text);
                llenarDataSet(); 
                textBoxTipo.Clear();
            }
        }
    }
}
