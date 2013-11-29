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
    public partial class FormPeriodoAcademico : Form
    {
        public FormPeriodoAcademico()
        {
            InitializeComponent();
        }

        private void textBoxEstado_KeyUp(object sender, KeyEventArgs e)
        {
         
            
        }

        private void textBoxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void textBoxidEstadoActividad_TextChanged(object sender, EventArgs e)
        { }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "" || txtSigla.Text == "")
            {
                MessageBox.Show("Un campo esta vacio");
            }
            else
            {
                Controlador.ControladorPeriodoAcademico.adicionar(Int32.Parse(txtAnio.Text),txtSigla.Text);
                llenarDataSet();
            }
        }




        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!textBoxidEstadoActividad.Text.Equals(""))
            {

                Controlador.ControladorPeriodoAcademico.eliminar(Int32.Parse(textBoxidEstadoActividad.Text));
            }
            else
            {
                MessageBox.Show("No esta seleccionado ningun Periodo academico");
            }
            llenarDataSet();
        }

        private void llenarDataSet()
        {
            System.Data.DataTable t = Controlador.ControladorPeriodoAcademico.getDataSetTodos();
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
                Controlador.ControladorPeriodoAcademico.modificar(id, Int32.Parse(txtAnio.Text),txtSigla.Text);
                llenarDataSet();
                textBoxidEstadoActividad.Clear();
            }
        }

        private void dataGridViewEstados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewEstados_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxidEstadoActividad.Text = dataGridViewEstados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAnio.Text = dataGridViewEstados.Rows[e.RowIndex].Cells[1
                ].Value.ToString();
        }


        



    }
}
