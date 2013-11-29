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
    public partial class FormActividadPeriodo : Form
    {
        public FormActividadPeriodo()
        {
            InitializeComponent();
        }

        private void actualizargrid()
        {
            try
            {
                int periodoSeleccionado = int.Parse(comboBox1.SelectedValue.ToString());
                System.Data.DataTable t = Controlador.ControladorActividadPeriodo.getDataSetTodosActividadNombre(periodoSeleccionado);
                dataGridListaActividadesEnPeriodo.AutoGenerateColumns = true;
                dataGridListaActividadesEnPeriodo.DataSource = t;
                dataGridListaActividadesEnPeriodo.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }

        private void FormActividadPeriodo_Load(object sender, EventArgs e)
        {
           
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            System.Data.DataTable t = Controlador.ControladorActividad.getDataSetTodos();
            dataGridActividades.AutoGenerateColumns = true;
            dataGridActividades.DataSource = t;
            dataGridActividades.Columns[0].Visible = false;


            DataTable listaEstados = Controlador.ControladorPeriodoAcademico.getDataSetTodosTexto();
            comboBox1.DataSource = listaEstados;
            comboBox1.DisplayMember = "texto";
            comboBox1.ValueMember = "idPeriodo";

            comboBox1.SelectedIndex = 0;
            actualizargrid();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizargrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                
                int idRelacion = Int32.Parse(dataGridListaActividadesEnPeriodo.CurrentRow.Cells[0].Value.ToString());
                
                Controlador.ControladorActividadPeriodo.eliminar(idRelacion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }
            actualizargrid();
            actualizargrid();
        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            try {

                
                int idActividadSeleccionada = Int32.Parse(dataGridActividades.CurrentRow.Cells[0].Value.ToString());
                int periodoSeleccionado = Int32.Parse(comboBox1.SelectedValue.ToString());

                Controlador.ControladorActividadPeriodo.adicionar(idActividadSeleccionada,periodoSeleccionado);

            } catch (Exception ex) {
                MessageBox.Show("Seleccione una actividad para adicionar");
            }
            actualizargrid();
        }
    }
}
