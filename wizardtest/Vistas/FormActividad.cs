using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace wizardtest.Vistas
{
    public partial class FormActividad : Form
    {
        public FormActividad()
        {
            InitializeComponent();
        }

        

        private void textBoxHoraInicio_Validating(object sender, CancelEventArgs e)
        {
            
            TextBox box = sender as TextBox;
            string pattern = "\\d{1,2}:\\d{2}";

            if (box != null)
            {
                if (!Regex.IsMatch(box.Text, pattern, RegexOptions.CultureInvariant))
                {
                    MessageBox.Show("Hora no valida ('hh:mm').");
                    e.Cancel = true;
                    box.Select(0, box.Text.Length);
                }
            }

        }
        private void llenarDataSet()
        {
            System.Data.DataTable t = Controlador.ControladorActividad.getDataSetTodos();
            dataGridViewActividades.AutoGenerateColumns = true;
            dataGridViewActividades.DataSource = t;
            dataGridViewActividades.Columns[0].Visible = false;
            textBoxIdActividad.Text = "";
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
                {
                    int indiceTipo = Int32.Parse(comboBoxTipo.SelectedValue.ToString());
                    int estadoTipo = Int32.Parse(comboBoxEstado.SelectedValue.ToString());
                    Controlador.ControladorActividad.adicionar(textBoxNombre.Text,indiceTipo, estadoTipo,comboBoxDia.SelectedIndex, textBoxHoraInicio.Text, textBoxHoraFin.Text, textBoxUbicacion.Text);
                    llenarDataSet();
                }
        private void FormActividad_Load(object sender, EventArgs e)
        {
            
              DataTable listaEstados = Controlador.GestionEstadoActividad.getDataSetTodos();
              comboBoxEstado.DataSource = listaEstados;
              comboBoxEstado.DisplayMember = "nombre";
              comboBoxEstado.ValueMember = "idestado";
              DataTable listaTipos = Controlador.GestionTipoActividad.getDataSetTodos();
              comboBoxTipo.DataSource = listaTipos;
              comboBoxTipo.DisplayMember = "nombre";
              comboBoxTipo.ValueMember = "idtipo";

            llenarDataSet();
            limpiarCampos();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(textBoxIdActividad.Text, out id))
            {
                int indiceTipo = Int32.Parse(comboBoxTipo.SelectedValue.ToString());
                int estadoTipo = Int32.Parse(comboBoxEstado.SelectedValue.ToString());
                Controlador.ControladorActividad.modificar(id, textBoxNombre.Text, indiceTipo, estadoTipo, comboBoxDia.SelectedIndex, textBoxHoraInicio.Text, textBoxHoraFin.Text, textBoxUbicacion.Text);
                
                llenarDataSet();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
            int id;
            if (Int32.TryParse(textBoxIdActividad.Text, out id))
            {
                Controlador.ControladorActividad.eliminar(id);
                llenarDataSet();
            }
        }

        private void dataGridViewActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewActividades_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewActividades.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBoxIdActividad.Text = dataGridViewActividades.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridViewActividades.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxTipo.SelectedValue = dataGridViewActividades.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxEstado.SelectedValue = dataGridViewActividades.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxDia.SelectedIndex = Int32.Parse(dataGridViewActividades.Rows[e.RowIndex].Cells[4].Value.ToString());
                textBoxHoraInicio.Text = dataGridViewActividades.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxHoraFin.Text = dataGridViewActividades.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxUbicacion.Text = dataGridViewActividades.Rows[e.RowIndex].Cells[7].Value.ToString();
                // textBoxTipo.Text = dataGridViewTipos.Rows[e.RowIndex].Cells[1
                //   ].Value.ToString();
            }
            

        }
        private void limpiarCampos()
        {
            textBoxHoraFin.Text = "";
            textBoxHoraInicio.Text = "";
            textBoxIdActividad.Text = "";
            textBoxNombre.Text = "";
            textBoxUbicacion.Text = "";
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
