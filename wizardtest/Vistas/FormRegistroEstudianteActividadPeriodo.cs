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
    public partial class FormRegistroEstudianteActividadPeriodo : Form
    {
        public FormRegistroEstudianteActividadPeriodo()
        {
            InitializeComponent();
        }

        private void refrescarListas()
        {
            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");
            DataTable listaEstudiantes = Controlador.ControladorRegistroEstudianteActividadPeriodo.getDataSetEstudiantesNoRegistrados(idPeriodoActual);
            dgEstudiantes.AutoGenerateColumns = true;
            dgEstudiantes.DataSource = listaEstudiantes;
            dgEstudiantes.Columns[0].Visible = false;
            dgEstudiantes.AutoResizeColumns();
            int valor;
            if (Int32.TryParse(cbActividadesPeriodo.SelectedValue.ToString(), out valor))
            {
                actualizarListaEstudiantesActividad(valor);
            }
            
        }

        private void FormRegistroEstudianteActividadPeriodo_Load(object sender, EventArgs e)
        {
            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");

            System.Data.DataTable t = Controlador.ControladorActividadPeriodo.getDataSetTodosActividadNombre(idPeriodoActual);
            dgActividadesPeriodo.AutoGenerateColumns = true;
            dgActividadesPeriodo.DataSource = t;
            dgActividadesPeriodo.Columns[0].Visible = false;
            dgActividadesPeriodo.AutoResizeColumns();

            DataTable listaAct = Controlador.ControladorActividadPeriodo.getDataSetTodosActividadNombre(idPeriodoActual);
            cbActividadesPeriodo.DataSource = listaAct;
            cbActividadesPeriodo.ValueMember = "idActividad";
            cbActividadesPeriodo.DisplayMember = "nombre";
            cbActividadesPeriodo.SelectedIndex = 0;



            refrescarListas();

        }

        private void btnGuardarLista_Click(object sender, EventArgs e)
        {
            int idEstudiante = 0;
            if (dgEstudiantes.SelectedRows.Count > 0 && Int32.TryParse(dgEstudiantes.SelectedRows[0].Cells["idEstudiante"].Value.ToString(), out idEstudiante))
            {

            }
            else
            {
                MessageBox.Show("Seleccione un estudiante");
                return;
            }

            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");


            int valor;
            if (Int32.TryParse(cbActividadesPeriodo.SelectedValue.ToString(), out valor))
            {
                Controlador.ControladorRegistroEstudianteActividadPeriodo.adicionar(idEstudiante, valor, idPeriodoActual);
            }

            refrescarListas();
            
        }

        private void actualizarListaEstudiantesActividad(int i){
            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");
            System.Data.DataTable t = Controlador.ControladorRegistroEstudianteActividadPeriodo.getDataSetEstudiantes(i, idPeriodoActual);
            dgEstudiantesEnActividad.AutoGenerateColumns = true;
            dgEstudiantesEnActividad.DataSource = t;
            dgEstudiantesEnActividad.Columns[0].Visible = false;
            dgEstudiantesEnActividad.AutoResizeColumns();
        }

        private void cbActividadesPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            int valor;
            if (Int32.TryParse(cbActividadesPeriodo.SelectedValue.ToString(),out valor))
            {
                actualizarListaEstudiantesActividad(valor);
            }
            
        }

        private void cbActividadesPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitarEstudianteSeleccionado_Click(object sender, EventArgs e)
        {
            int idRegistroEliminar = 0;
            if (dgEstudiantesEnActividad.SelectedRows.Count > 0 && Int32.TryParse(dgEstudiantesEnActividad.SelectedRows[0].Cells["id"].Value.ToString(), out idRegistroEliminar))
            {
                if (MessageBox.Show("Desea remover al estudiante de la actividad?", "Remover", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Controlador.ControladorRegistroEstudianteActividadPeriodo.eliminar(idRegistroEliminar);
                }
            }
            
            refrescarListas();
        }
    }
}
