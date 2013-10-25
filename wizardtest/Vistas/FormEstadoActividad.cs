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
    public partial class FormEstadoActividad : Form
    {
        public FormEstadoActividad()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Controlador.GestionEstadoActividad.adicionar(textBoxEstado.Text);
            llenarDataSet();
        }




        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!textBoxidEstadoActividad.Text.Equals(""))
            {

                Controlador.GestionEstadoActividad.eliminar(Int32.Parse(textBoxidEstadoActividad.Text));
            }
            else
            {
                MessageBox.Show("No esta seleccionado ningun Estado Actividad");
            }
            llenarDataSet();
        }

        private void llenarDataSet()
        {
            System.Data.DataTable t = Controlador.GestionEstadoActividad.getDataSetTodos();
            dataGridViewEstados.AutoGenerateColumns = true;
            dataGridViewEstados.DataSource = t;
            dataGridViewEstados.Columns[0].Visible = false;
            textBoxidEstadoActividad.Text = "";
        }

        private void FormEstadoActividad_Load(object sender, EventArgs e)
        {
            llenarDataSet();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(textBoxidEstadoActividad.Text, out id))
            {
                Controlador.GestionEstadoActividad.modificar(id, textBoxEstado.Text);
                llenarDataSet();
                textBoxidEstadoActividad.Clear();
            }
        }

        private void dataGridViewEstados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxidEstadoActividad.Text = dataGridViewEstados.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxEstado.Text = dataGridViewEstados.Rows[e.RowIndex].Cells[1
                ].Value.ToString();
        }
    }
}
